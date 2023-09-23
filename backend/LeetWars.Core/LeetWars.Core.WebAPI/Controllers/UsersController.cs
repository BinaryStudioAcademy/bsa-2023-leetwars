using System.Security.Claims;
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
        var createdUser = await _userService.CheckIsExistingEmailAsync(email);
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
        var isExistingUserName = await _userService.CheckIsExistingUserNameAsync(username);
        return Ok(isExistingUserName);
    }

    [HttpGet("current")]
    public async Task<ActionResult<UserDto>> GetCurrentUser()
    {
        var currentUser = await _userService.GetCurrentUserAsync();
        return Ok(currentUser);
    }

    [HttpGet("{id}/user-challenges")]
    public async Task<ActionResult<List<UserSolutionsGroupedBySkillLevelDto>>> GetUserChallengesInfoByTags(long id)
    {
        var challenges =  await _userService.GetUserChallengesInfoByTagsAsync(id);
        return Ok(challenges);
    }

    [HttpGet("leader-board")]
    public async Task<ActionResult<List<UserDto>>> GetLeaderBoardAsync([FromQuery] PageSettingsDto page)
    {
        var users = await _userService.GetLeaderBoardAsync(page);
        return Ok(users);
    }    

    [HttpPut]
    [Route("rank")]
    public async Task<ActionResult<UserFullDto>> UpdateUserRank([FromBody] EditUserDto userDto)
    {
        var updatedUser = await _userService.UpdateUserRankAsync(userDto);
        return Ok(updatedUser);
    }
    
    [HttpPut]
    public async Task<ActionResult<UserDto>> UpdateUser(UpdateUserInfoDto updateUserInfoDto)
    {
        var updatedUser = await _userService.UpdateUserInfo(updateUserInfoDto);
        
        return Ok(updatedUser);
    }
    
    [HttpPost("avatar")]
    public async Task<ActionResult<UserAvatarDto>> UpdateUserAvatar([FromForm] IFormFile avatar)
    {
        var newAvatarUrl = await _userService.UpdateUserAvatar(avatar);
        
        return Ok(newAvatarUrl);
    }
}