using AutoMapper;
using Bogus;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.BLL.Helpers.Email;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.Common.Extensions;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using LeetWars.Core.DAL.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LeetWars.Core.BLL.Services;

public class UserService : BaseService, IUserService
{
    private readonly IUserGetter _userGetter;
    private readonly IEmailSenderService _emailSenderService;
    private readonly IBlobService _blobService;
    private const int REPUTATION_DIVIDER = 10;

    public UserService(LeetWarsCoreContext context,
                       IMapper mapper,
                       IUserGetter userGetter,
                       IEmailSenderService emailSenderService,
                       IBlobService blobService
                       ) : base(context, mapper)
    {
        _userGetter = userGetter;
        _emailSenderService = emailSenderService;
        _blobService = blobService;
    }

    public async Task<UserDto> CreateUserAsync(NewUserDto userDto)
    {
        if (userDto is null)
        {
            throw new NotFoundException(nameof(User));
        }

        var user = await _context.Users.SingleOrDefaultAsync(u => u.Uid == userDto.Uid);

        if (user is not null)
        {
            return _mapper.Map<UserDto>(user);
        }

        bool isExistingEmail = await CheckIsExistingEmailAsync(userDto.Email);

        if (isExistingEmail)
        {
            throw new InvalidUsernameOrPasswordException($"Error: A user with email {userDto.Email} is already registered.");
        }

        bool isExistingUserName = await CheckIsExistingUserNameAsync(userDto.UserName);

        if (isExistingUserName)
        {
            userDto.UserName = userDto.IsWithProvider
                ? await GenerateUniqueUsername(userDto.Email)
                : throw new InvalidUsernameOrPasswordException($"Error: This username is already registered in the system.");
        }

        var newUser = _mapper.Map<NewUserDto, User>(userDto);

        newUser.RegisteredAt = DateTime.UtcNow;

        var createdUser = _context.Users.Add(newUser).Entity;
        await _context.SaveChangesAsync();

        var welcomeEmail = EmailGenerator.GenerateWelcomeEmail(createdUser.UserName, createdUser.Email);
        _emailSenderService.SendEmailMessageToRabbitMQ(welcomeEmail);

        return _mapper.Map<UserDto>(createdUser);
    }

    public async Task<bool> CheckIsExistingEmailAsync(string email)
    {
        bool isExistingEmail = await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
        return isExistingEmail;
    }

    public async Task<bool> CheckIsExistingUserNameAsync(string? userName)
    {
        if (string.IsNullOrEmpty(userName))
        {
            return true;
        }

        bool isExistingUserName = await _context.Users.AnyAsync(u => u.UserName.ToLower() == userName.ToLower());
        return isExistingUserName;
    }

    public async Task<User?> GetUserByExpressionAsync(Expression<Func<User, bool>> expression)
    {
        return await _context.Users
            .Include(user => user.Subscriptions)
            .Include(user => user.PreferredLanguages)
            .Include(user => user.LanguagesWithLevels)
            .Include(user => user.Solutions)
            .Include(user => user.Challenges)
            .Include(user => user.UserBadges)
                .ThenInclude(badge => badge.Badge)
            .Include(user => user.ChallengeVersions)
            .FirstOrDefaultAsync(expression);
    }

    public async Task<UserDto> GetCurrentUserAsync()
    {
        var user = await GetCurrentUserEntityAsync();

        return _mapper.Map<UserDto>(user);
    }

    public async Task<BriefUserInfoDto> GetBriefUserInfoByIdAsync(long id)
    {
        var user = await GetUserByExpressionAsync(user => user.Id == id);

        if (user is null)
        {
            throw new ArgumentNullException("Not Found", new Exception("User was not found"));
        }

        return _mapper.Map<User, BriefUserInfoDto>(user);
    }

    public async Task<UserDto> GetUserAsync(long id)
    {
        var user = await GetUserByExpressionAsync(user => user.Id == id);

        if (user is null)
        {
            throw new NotFoundException(nameof(User), id);
        }

        return _mapper.Map<User, UserDto>(user);
    }

    public async Task<UserFullDto> GetFullUserAsync(long id)
    {
        var user = await GetUserByExpressionAsync(user => user.Id == id);

        if (user is null)
        {
            throw new NotFoundException(nameof(User), id);
        }

        return _mapper.Map<User, UserFullDto>(user);
    }

    public async Task<List<UserSolutionsGroupedBySkillLevelDto>> GetUserChallengesInfoByTagsAsync(long currentUserId)
    {
        var challenges = await _context.Challenges
            .Include(x => x.Level)
            .Include(x => x.Tags)
            .Include(challenge => challenge.Versions)
                .ThenInclude(version => version.Solutions)
                    .ThenInclude(solution => solution.User)
            .GroupBy(x => x.Level!.SkillLevel)
            .Select(x => new UserSolutionsGroupedBySkillLevelDto
            {
                TotalCount = x.Count(),
                Name = x.Key,
                TaskCountDtos = x
                    .Where(x => x.Versions.SelectMany(s => s.Solutions).Any(y => y.SubmittedAt.HasValue && y.User!.Id == currentUserId))
                    .SelectMany(y => y.Tags)
                    .GroupBy(y => y.Name)
                    .Select(y => new TaskCountDto { Name = y.Key, ChallengeCount = y.Count() }),
            })
            .ToListAsync();

        return challenges;
    }

    public async Task<UserFullDto> UpdateUserRankAsync(EditUserDto userDto)
    {
        var user = await GetUserByExpressionAsync(user => user.Id == userDto.Id)
            ?? throw new NotFoundException(nameof(User), userDto.Id);

        user.TotalScore += await GetRewardFromChallenge(userDto.CompletedChallengeId);
        user.Reputation = user.TotalScore / REPUTATION_DIVIDER;

        _context.Users.Update(user);

        await _context.SaveChangesAsync();

        return _mapper.Map<UserFullDto>(user);
    }

    public async Task<List<UserDto>> GetLeaderBoardAsync(PageSettingsDto? page)
    {
        var users = _context.Users.OrderByDescending(u => u.TotalScore).AsQueryable();
        if (page is not null)
        {
            users = users.Skip(page.PageSize * (page.PageNumber - 1))
                         .Take(page.PageSize);
        }

        return _mapper.Map<List<UserDto>>(await users.ToListAsync());
    }

    public async Task<UserDto> UpdateUserInfoAsync(UpdateUserInfoDto userInfoDto)
    {
        if (userInfoDto is null)
        {
            throw new NotFoundException(nameof(UpdateUserInfoDto));
        }

        var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Uid == _userGetter.CurrentUserId)
                            ?? throw new NotFoundException(nameof(User), _userGetter.CurrentUserId);

        _mapper.Map(userInfoDto, currentUser);

        _context.Users.Update(currentUser);
        await _context.SaveChangesAsync();
        return _mapper.Map<UserDto>(currentUser);
    }

    public async Task<UserAvatarDto> UpdateUserAvatarAsync(IFormFile image)
    {
        if (image is null)
        {
            throw new ArgumentNullException(nameof(image));
        }

        var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Uid == _userGetter.CurrentUserId)
                          ?? throw new NotFoundException(nameof(User), _userGetter.CurrentUserId);

        var uniqueFileName = FileNameHelper.CreateUniqueFileName(image.FileName);
        await _blobService.UploadFileBlobAsync(image.OpenReadStream(), image.ContentType,
            uniqueFileName);
        currentUser.ImagePath = uniqueFileName;

        _context.Users.Update(currentUser);
        await _context.SaveChangesAsync();

        var newUserAvatar = new UserAvatarDto(_blobService.GetBlob(uniqueFileName));
        return newUserAvatar;
    }

    private async Task<User> GetCurrentUserEntityAsync()
    {
        var userStringId = _userGetter.CurrentUserId;
        var user = await GetUserByExpressionAsync(user => user.Uid == userStringId);

        return user ?? throw new NotFoundException(nameof(User));
    }

    private async Task<int> GetRewardFromChallenge(long challengeId)
    {
        var challengeLevel = await _context.Challenges
            .Select(challenge => new ChallengeRewardDto
            {
                ChallengeId = challenge.Id,
                Reward = challenge.Level != null ? challenge.Level.Reward : 0,
            })
            .SingleOrDefaultAsync(level => level.ChallengeId == challengeId);

        return challengeLevel?.Reward
            ?? throw new NotFoundException(nameof(Challenge), challengeId);
    }

    private async Task<string> GenerateUniqueUsername(string email)
    {
        string newUserName = email.GetUserNameFromEmail();

        while (await CheckIsExistingUserNameAsync(newUserName))
        {
            newUserName = new Faker<string>()
                .CustomInstantiator(f => f.Internet.UserName().LimitLength(EntitySettings.MaxUserNameLength - 3));
        }

        return newUserName;
    }
}
