using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.BLL.Services;
using LeetWars.Core.Common.DTO;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChallengeController : ControllerBase
    {
        public ChallengeController(IChallengeService challengeService) 
        {
            _challengeService = challengeService;
        }

        [HttpGet]
        public async Task<ActionResult<ChallengePreviewDto>> GetAllAsync([FromQuery] ChallengesFiltersDto filters)
        {
            var challenges = await _challengeService.GetChallengesAsync(filters);
            return Ok(challenges);
        }

        private readonly IChallengeService _challengeService;
    }
}
