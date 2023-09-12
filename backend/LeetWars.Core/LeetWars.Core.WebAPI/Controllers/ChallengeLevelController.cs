using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.Common.DTO.ChallengeVersion;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChallengeLevelController : ControllerBase
{
    private readonly IChallengeLevelService _challengeLevelService;
        
    public ChallengeLevelController(IChallengeLevelService challengeLevelService) 
    {
        _challengeLevelService = challengeLevelService;
    }

    [HttpGet]
    public async Task<ActionResult<ICollection<ChallengeLevelDto>>> GetAllAsync()
    {
        var levels = await _challengeLevelService.GetAllLevelsAsync();
        return Ok(levels);
    }
}