using LeetWars.Core.BLL.Services;
using LeetWars.Core.Common.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("users")]
public class UsersController :ControllerBase
{
    private readonly IUserService _userService;
    
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost]
    [AllowAnonymous]
    public async Task<ActionResult<UserDto>> CreateUser([FromBody] NewUserDto user)
    {
        var createdUser = await _userService.CreateUserAsync(user);
        return Ok(createdUser);
    }
}