using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.Friendship;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.Common.DTO.UserPrefferences;
using LeetWars.Core.Common.DTO.UserSolution;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;

namespace LeetWars.Core.BLL.Interfaces;

public interface IUserService
{
    public Task<UserDto> CreateUserAsync(NewUserDto userDto);

    public Task<bool> CheckIsExistingEmailAsync(string email);

    public Task<bool> CheckIsExistingUserNameAsync(string userName);

    public Task<User?> GetUserByExpressionAsync(Expression<Func<User, bool>> expression);

    public Task<UserDto> GetCurrentUserAsync();

    public Task<UserDto> GetUserAsync(long id);

    public Task<UserFullDto> GetFullUserAsync(long id);

    public Task<List<UserSolutionsGroupedBySkillLevelDto>> GetUserChallengesInfoByTagsAsync(long currentUserId);

    public Task<UserFullDto> UpdateUserRankAsync(EditUserDto userDto);

    public Task<BriefUserInfoDto> GetBriefUserInfoByIdAsync(long id);

    public Task<List<UserDto>> GetLeaderBoardAsync(LeaderBoardPageSettingsDto page);

    public Task<UserFriendsInfoDto> GetUserFriendshipsAsync(long userId);

    public Task<UserFriendsInfoDto> SendFriendshipRequestAsync(NewFriendshipDto newFriendshipDto);

    public Task<UserFriendsInfoDto> UpdateFriendshipRequestAsync(UpdateFriendshipDto updateFriendshipDto);

    public Task<UserDto> UpdateUserInfoAsync(UpdateUserInfoDto userInfoDto);

    public Task<UserAvatarDto> UpdateUserAvatarAsync(IFormFile image);

    public Task<UserPreferencesDto> GetUserPreferences();

    public Task<UserPreferencesDto> SetUserPreferences(NewUserPreferencesDto newPreferences);

    public Task<UserSolutionDto> SubmitSolutionAsync(NewUserSolutionDto userSolutionDto);
}