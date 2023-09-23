using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeLevel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class ChallengeLevelController : ControllerBase
{
    private readonly IChallengeLevelService _challengeLevelService;

    public ChallengeLevelController(IChallengeLevelService challengeLevelService)
    {
        _challengeLevelService = challengeLevelService;
    }

    /// <summary>
    /// Get all challenge levels
    /// </summary>
    /// <returns>Collection of challenge levels</returns>
    [HttpGet]
    public async Task<ActionResult<ICollection<ChallengeLevelDto>>> GetAllAsync()
    {
        var levels = await _challengeLevelService.GetAllLevelsAsync();

        return Ok(levels);
    }
}