using LeetWars.Core.Common.DTO.User;

namespace LeetWars.Core.BLL.Services;

public interface IUserService
{
    public Task<UserDto> CreateUserAsync(NewUserDto userDto);
}