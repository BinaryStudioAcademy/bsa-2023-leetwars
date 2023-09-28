using AutoMapper;
using Bogus;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.BLL.Helpers.Email;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.Friendship;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.Common.Exceptions;
using LeetWars.Core.Common.Extensions;
using LeetWars.Core.DAL.Context;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using LeetWars.Core.DAL.Enums;
using LeetWars.Core.DAL.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LeetWars.Core.BLL.Services;

public class UserService : BaseService, IUserService
{
    private readonly IUserGetter _userGetter;
    private readonly INotificationService _notificationService;
    private readonly IEmailSenderService _emailSenderService;
    private readonly IBlobService _blobService;
    private const int REPUTATION_DIVIDER = 10;

    public UserService(LeetWarsCoreContext context,
                       IMapper mapper,
                       IUserGetter userGetter,
                       INotificationService notificationService,
                       IEmailSenderService emailSenderService,
                       IBlobService blobService
                       ) : base(context, mapper)
    {
        _userGetter = userGetter;
        _notificationService = notificationService;
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
                ? await GenerateUniqueUsernameAsync(userDto.Email)
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
            .Include(user => user.Friendships)
                .ThenInclude(friendship => friendship.Users)
            .Include(user => user.Friendships)
                .ThenInclude(f => f.UserFriendships)
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

        user.TotalScore += await GetRewardFromChallengeAsync(userDto.CompletedChallengeId);
        user.Reputation = user.TotalScore / REPUTATION_DIVIDER;

        _context.Users.Update(user);

        await _context.SaveChangesAsync();

        return _mapper.Map<UserFullDto>(user);
    }

    public async Task<List<UserDto>> GetLeaderBoardAsync(LeaderBoardPageSettingsDto page)
    {
        var query = _context.Users.OrderByDescending(u => u.TotalScore).AsQueryable();

        if (page.HasFriends)
        {
            var currentUser = await GetUserInfoWithFriends(u => u.Uid == _userGetter.CurrentUserId);
            var currentUserDto = _mapper.Map<UserDto>(currentUser);

            var currentUserFriendsIds = currentUserDto.Friendships?
                .Where(f => f.FriendshipStatus == FriendshipStatus.Accepted)
                .Select(f => f.FriendId) ?? throw new NotFoundException(nameof(List<User>));

            query = query.Where(u => currentUserFriendsIds.Contains(u.Id));
        }

        query = query.Skip(page.PageSize * (page.PageNumber - 1)).Take(page.PageSize);

        return _mapper.Map<List<UserDto>>(await query.ToListAsync());
    }

    public async Task<UserFriendsInfoDto> SendFriendshipRequestAsync(NewFriendshipDto newFriendshipDto)
    {
        var sender = await GetUserInfoWithFriends(u => u.Id == newFriendshipDto.SenderId)
            ?? throw new NotFoundException(nameof(User), newFriendshipDto.SenderId);

        if (sender.Friendships
            .SelectMany(f => f.UserFriendships)
            .GroupBy(uf => uf.FriendshipId)
            .Any(group => group.Any(uf => uf.UserId == newFriendshipDto.RecipientId)))
        {
            throw new BadOperationException($"You can't send a friendship request to this user");
        }

        var currentDateTime = DateTime.UtcNow;
        var friendship = new Friendship(currentDateTime, FriendshipStatus.Pending);

        _context.Friendships.Add(friendship);
        await _context.SaveChangesAsync();

        var senderUserFriendship = new UserFriendship(newFriendshipDto.SenderId, friendship.Id, true);
        var recipientUserFriendship = new UserFriendship(newFriendshipDto.RecipientId, friendship.Id, false);

        _context.UserFriendships.Add(senderUserFriendship);
        _context.UserFriendships.Add(recipientUserFriendship);

        await _context.SaveChangesAsync();

        var newNotification = new NotificationDto
        {
            DateSending = DateTime.UtcNow,
            ReceiverId = newFriendshipDto.RecipientId.ToString(),
            Sender = await GetBriefUserInfoByIdAsync(sender.Id),
            TypeNotification = TypeNotifications.FriendRequest,
            Message = $"{sender.UserName} sent you a friend request",
            UpdateFriendship = new UpdateFriendshipDto(sender.Id, friendship.Id, friendship.Status)
        };

        await _notificationService.CreateNotification(newNotification);
        _notificationService.SendNotification(newNotification);

        return _mapper.Map<UserFriendsInfoDto>(senderUserFriendship.User);
    }

    public async Task<UserFriendsInfoDto> UpdateFriendshipRequestAsync(UpdateFriendshipDto updateFriendshipDto)
    {
        var user = await GetUserInfoWithFriends(u => u.Id == updateFriendshipDto.UserId)
            ?? throw new NotFoundException(nameof(User));

        ThrowIfIsNotMatchingIds(updateFriendshipDto.UserId, user.Id);

        var friendshipToUpdate = user.Friendships.FirstOrDefault(f => f.Id == updateFriendshipDto.FriendshipId)
            ?? throw new NotFoundException(nameof(Friendship), (int)updateFriendshipDto.FriendshipId);

        switch (updateFriendshipDto.FriendshipStatus)
        {
            case FriendshipStatus.Pending:
                throw new BadOperationException("You cannot update a friendship status as 'Pending'");
            case FriendshipStatus.Declined:
                _context.Friendships.Remove(friendshipToUpdate);
                break;
            case FriendshipStatus.Accepted:
                friendshipToUpdate.Status = updateFriendshipDto.FriendshipStatus;
                break;
            default:
                throw new BadOperationException("Not expected friendship status value");
        }
        await _context.SaveChangesAsync();

        var userFriendship = friendshipToUpdate.UserFriendships.First(uf => uf.UserId != user.Id);

        var newNotification = new NotificationDto
        {
            DateSending = DateTime.UtcNow,
            ReceiverId = userFriendship.UserId.ToString(),
            Sender = await GetBriefUserInfoByIdAsync(user.Id),
            TypeNotification = TypeNotifications.UpdateFriendRequest,
            UpdateFriendship = new UpdateFriendshipDto(user.Id, friendshipToUpdate.Id, updateFriendshipDto.FriendshipStatus)
        };

        _notificationService.SendNotification(newNotification);

        return _mapper.Map<UserFriendsInfoDto>(user);
    }

    public async Task<UserFriendsInfoDto> GetUserFriendshipsAsync(long userId)
    {
        var user = await GetUserInfoWithFriends(u => u.Id == userId) ?? throw new NotFoundException(nameof(User));

        return _mapper.Map<UserFriendsInfoDto>(user);
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

    private async Task<int> GetRewardFromChallengeAsync(long challengeId)
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

    private async Task<string> GenerateUniqueUsernameAsync(string email)
    {
        string newUserName = email.GetUserNameFromEmail();

        while (await CheckIsExistingUserNameAsync(newUserName))
        {
            newUserName = new Faker<string>()
                .CustomInstantiator(f => f.Internet.UserName().LimitLength(EntitySettings.MaxUserNameLength - 3));
        }

        return newUserName;
    }

    private async Task<User?> GetUserInfoWithFriends(Expression<Func<User, bool>> expression)
    {
        var user = await _context.Users
            .Include(user => user.Friendships)
                .ThenInclude(friendship => friendship.Users)
            .Include(user => user.Friendships)
                .ThenInclude(f => f.UserFriendships)
            .FirstOrDefaultAsync(expression);

        return user;
    }

    private static void ThrowIfIsNotMatchingIds(long userId, long currentUserId)
    {
        if (userId != currentUserId)
        {
            throw new BadOperationException($"User id: {userId} should match with current user id: {currentUserId}");
        }
    }
}
