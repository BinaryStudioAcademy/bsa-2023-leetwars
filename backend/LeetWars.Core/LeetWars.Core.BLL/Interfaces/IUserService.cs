using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.BLL.Services;

public interface IUserService
{
    public Task<UserDto> CreateUserAsync(NewUserDto userDto);
    public Task<bool> CheckIsExistingEmailAsync(string email);
    public Task<bool> CheckIsExistingUserNameAsync(string userName);
    public Task<User?> GetUserByIdAsync(long id);
    public Task<UserDto> GetCurrentUserAsync();
    public Task<UserFullDto> GetFullUserAsync(long id);
    public Task<List<UserSolutionsGroupedBySkillLevelDto>> GetUserChallengesInfoByTagsAsync(long currentUserId);
    public Task<UserFullDto> UpdateUserAsync(UserFullDto userDto);
}