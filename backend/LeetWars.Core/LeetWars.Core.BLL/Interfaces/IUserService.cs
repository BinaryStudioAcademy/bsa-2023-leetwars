using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Filters;

using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Http;

namespace LeetWars.Core.BLL.Interfaces;

public interface IUserService
{
    public Task<UserDto> CreateUserAsync(NewUserDto userDto);
    public Task<bool> CheckIsExistingEmailAsync(string email);
    public Task<bool> CheckIsExistingUserNameAsync(string userName);
    public Task<User?> GetUserByExpressionAsync(Expression<Func<User, bool>> expression);
    public Task<UserDto> GetCurrentUserAsync();
    public Task<UserFullDto> GetFullUserAsync(long id);
    public Task<List<UserSolutionsGroupedBySkillLevelDto>> GetUserChallengesInfoByTagsAsync(long currentUserId);
    public Task<UserFullDto> UpdateUserRankAsync(EditUserDto userDto);
    public Task<BriefUserInfoDto> GetBriefUserInfoById(long id);
    public Task<List<UserDto>> GetLeaderBoardAsync(PageSettingsDto? page);
    public Task<UserDto> UpdateUserInfo(UpdateUserInfoDto userInfoDto);
    public Task<UserAvatarDto> UpdateUserAvatar(IFormFile image);
}