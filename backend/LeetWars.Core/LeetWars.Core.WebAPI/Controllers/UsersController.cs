using System.Security.Claims;
using LeetWars.Core.BLL.Services;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("users")]
public class UsersController : ControllerBase
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

    [HttpGet("is-existing-email")]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> CheckEmail([FromQuery] string email)
    {
        var createdUser = await _userService.CheckIsExistingEmail(email);
        return Ok(createdUser);

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserFullDto>> GetUser(int id)
    {
        var user = await _userService.GetFullUserAsync(id);
        return Ok(user);
    }

    [HttpGet("is-existing-username")]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> CheckUserName([FromQuery] string username)
    {
        var isExistingUserName = await _userService.CheckIsExistingUserName(username);
        return Ok(isExistingUserName);
    }

    [HttpGet("current")]
    public async Task<ActionResult<UserDto>> GetCurrentUser()
    {
        var uid = _userService.GetCurrentUserUid();
        var user = await _userService.GetUserByUidAsync(uid);
        return Ok(user);
    }

    [HttpGet("{id}/user-challenges")]
    public async Task<ActionResult<List<UserSolutionsGroupedBySkillLevelDto>>> GetUserChallengesInfoByTags(long id)
    {
        var challenges =  await _userService.GetUserChallengesInfoByTags(id);
        return Ok(challenges);
    }

}