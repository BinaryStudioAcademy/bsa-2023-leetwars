using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Filters;
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

    /// <summary>
    /// Get user info by id
    /// </summary>
    /// <param name="id">User id to find</param>
    /// <returns>User info</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<UserFullDto>> GetUserAsync(long id)
    {
        var user = await _userService.GetUserAsync(id);

        return Ok(user);
    }

    /// <summary>
    /// Get full user info by id
    /// </summary>
    /// <param name="id">User id to find</param>
    /// <returns>Full user info</returns>
    [HttpGet("full/{id}")]
    public async Task<ActionResult<UserFullDto>> GetFullUserAsync(long id)
    {
        var user = await _userService.GetFullUserAsync(id);

        return Ok(user);
    }

    /// <summary>
    /// Check if email already registered in our system
    /// </summary>
    /// <param name="email">Email to check</param>
    /// <returns>True if email registered, otherwise - false</returns>
    [HttpGet("is-existing-email")]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> CheckEmailAsync([FromQuery] string email)
    {
        var isEmailRegistered = await _userService.CheckIsExistingEmailAsync(email);

        return Ok(isEmailRegistered);
    }

    /// <summary>
    /// Check if username already registered in our system
    /// </summary>
    /// <param name="username">Username to check</param>
    /// <returns>True if username registered, otherwise - false</returns>
    [HttpGet("is-existing-username")]
    [AllowAnonymous]
    public async Task<ActionResult<bool>> CheckUserNameAsync([FromQuery] string username)
    {
        var isUserNameRegistered = await _userService.CheckIsExistingUserNameAsync(username);

        return Ok(isUserNameRegistered);
    }

    /// <summary>
    /// Get logged in user
    /// </summary>
    /// <returns>Current user</returns>
    [HttpGet("current")]
    public async Task<ActionResult<UserDto>> GetCurrentUserAsync()
    {
        var currentUser = await _userService.GetCurrentUserAsync();

        return Ok(currentUser);
    }

    /// <summary>
    /// Get user solutions grouped by skill level
    /// </summary>
    /// <param name="id">User id</param>
    /// <returns>List of user solutions group by skill level</returns>
    [HttpGet("{id}/user-challenges")]
    public async Task<ActionResult<List<UserSolutionsGroupedBySkillLevelDto>>> GetUserChallengesInfoByTagsAsync(long id)
    {
        var challenges = await _userService.GetUserChallengesInfoByTagsAsync(id);

        return Ok(challenges);
    }

    /// <summary>
    /// Get leaderboard information
    /// </summary>
    /// <param name="page">Page of leaderboard</param>
    /// <returns>List of users on leaderbloard</returns>
    [HttpGet("leader-board")]
    public async Task<ActionResult<List<UserDto>>> GetLeaderBoardAsync([FromQuery] PageSettingsDto page)
    {
        var users = await _userService.GetLeaderBoardAsync(page);

        return Ok(users);
    }

    /// <summary>
    /// Update user info
    /// </summary>
    /// <param name="updateUserInfoDto">User info to update</param>
    /// <returns>Updated user info</returns>
    [HttpPut]
    public async Task<ActionResult<UserDto>> UpdateUserAsync(UpdateUserInfoDto updateUserInfoDto)
    {
        var updatedUser = await _userService.UpdateUserInfoAsync(updateUserInfoDto);

        return Ok(updatedUser);
    }

    /// <summary>
    /// Create user (register or login)
    /// </summary>
    /// <param name="user">New user to create</param>
    /// <returns>Created user</returns>
    [HttpPost]
    [AllowAnonymous]
    public async Task<ActionResult<UserDto>> CreateUserAsync([FromBody] NewUserDto user)
    {
        var updatedUser = await _userService.CreateUserAsync(user);
        return Ok(updatedUser);
    }

    /// <summary>
    /// Update user avatar
    /// </summary>
    /// <param name="avatar">New avatar</param>
    /// <returns>New user avatar</returns>
    [HttpPost("avatar")]
    public async Task<ActionResult<UserAvatarDto>> UpdateUserAvatarAsync([FromForm] IFormFile avatar)
    {
        var updatedUser = await _userService.UpdateUserAvatarAsync(avatar);

        return Ok(updatedUser);
    }
}