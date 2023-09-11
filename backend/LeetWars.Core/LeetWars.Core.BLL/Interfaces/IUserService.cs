using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.User;

namespace LeetWars.Core.BLL.Services;

public interface IUserService
{
    public Task<UserDto> CreateUserAsync(NewUserDto userDto);
    public Task<bool> CheckIsExistingEmail(string email);
    public Task<bool> CheckIsExistingUserName(string userName);
    public Task<UserDto> GetUserByUidAsync(string uid);
    public string GetCurrentUserUid();
    public Task<UserFullDto> GetFullUserAsync(int id);

    public Task<List<UserSolutionsGroupedBySkillLevelDto>> GetUserChallengesInfoByTags(long currentUserId);

    public Task<List<UserDto>> GetLeaderBoardAsync(PageSettingsDto? page);
}