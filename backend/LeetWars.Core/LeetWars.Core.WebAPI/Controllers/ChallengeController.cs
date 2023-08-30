using LeetWars.Core.BLL.Interfaces;
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
        public async Task<ActionResult<ChallengePreviewDto>> GetAllAsync([FromQuery] ChallengesFiltersDto filters, [FromQuery] PageSettingsDto page)
        {
            var challenges = await _challengeService.GetChallengesAsync(filters, page);
            return Ok(challenges);
        }

        [HttpGet("suggestion")]
        public async Task<ActionResult<ChallengePreviewDto>> GetChallengeSuggestionAsync([FromQuery] SuggestionSettingsDto settings)
        {
            var challenge = await _challengeService.GetChallengeSuggestionAsync(settings);
            return Ok(challenge);
        }

        private readonly IChallengeService _challengeService;
    }
}
