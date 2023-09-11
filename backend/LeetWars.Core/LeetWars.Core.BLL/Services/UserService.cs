using System.Linq.Expressions;
using System.Security.Claims;
using System.Transactions;
using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.BLL.Services;

public class UserService : BaseService, IUserService
{
    private const int REPUTATION_DIVIDER = 10;
    private readonly IUserIdGetter _userGetter;

    public UserService(LeetWarsCoreContext context, IMapper mapper, IUserIdGetter userGetter) : base(context, mapper)
    {
        _userGetter = userGetter;
    }

    public async Task<UserDto> CreateUserAsync(NewUserDto userDto)
    {
        if (userDto is null)
        {
            throw new ArgumentNullException(nameof(userDto));
        }

        var user = await _context.Users.SingleOrDefaultAsync(u => u.Uid == userDto.Uid);

        if (user is not null)
        {
            return _mapper.Map<UserDto>(user);
        }

        bool isExistingEmail = await CheckIsExistingEmailAsync(userDto.Email);

        if (isExistingEmail)
        {
            throw new InvalidOperationException($"A user with email {userDto.Email} is already registered.");
        }

        var newUser = _mapper.Map<NewUserDto, User>(userDto);
        var createdUser = _context.Users.Add(newUser).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<UserDto>(createdUser);
    }

    public async Task<bool> CheckIsExistingEmailAsync(string email)
    {
        bool isExistingEmail = await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
        return isExistingEmail;
    }

    public async Task<bool> CheckIsExistingUserNameAsync(string userName)
    {
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
            .Include(user => user.ChallengeVersions)
            .SingleOrDefaultAsync(expression);
    }

    public async Task<UserDto> GetCurrentUserAsync()
    {
        var userStringId = _userGetter.CurrentUserId;

        var user = await GetUserByExpressionAsync(user => user.Uid == userStringId);

        return _mapper.Map<UserDto>(user);  
    }

    public async Task<UserFullDto> GetFullUserAsync(long id)
    {
        var user = await GetUserByExpressionAsync(user => user.Id == id);

        if (user is null)
        {
            throw new ArgumentNullException("Not Found", new Exception("User was not found"));
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

    public async Task<UserFullDto> UpdateUserAsync(EditUserDto userDto)
    {
        var user = await GetUserByExpressionAsync(user => user.Id == userDto.Id)
            ?? throw new ArgumentNullException(nameof(userDto));

        user.TotalScore += await GetRewardFromChallenge(userDto.CompletedChallengeId);
        user.Reputation = user.TotalScore / REPUTATION_DIVIDER;

        _context.Users.Update(user);

        await _context.SaveChangesAsync();

        return _mapper.Map<UserFullDto>(user);
    }

    private async Task<int> GetRewardFromChallenge(long challengeId)
    {
        var challenge = await _context.Challenges
            .Include(challenge => challenge.Level)
            .SingleOrDefaultAsync(challenge => challenge.Id == challengeId);

        return challenge?.Level?.Reward 
            ?? throw new ArgumentNullException(nameof(challengeId));
    }
}
