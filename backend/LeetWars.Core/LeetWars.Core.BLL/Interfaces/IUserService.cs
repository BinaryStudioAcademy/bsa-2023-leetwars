using LeetWars.Core.Common.DTO.User;

namespace LeetWars.Core.BLL.Services;

public interface IUserService
{
    public Task<UserDto> CreateUserAsync(NewUserDto userDto);
    public Task<bool> CheckIsExistingEmail(string email);
    public Task<UserDto> GetUserByUidAsync(string uid);
}