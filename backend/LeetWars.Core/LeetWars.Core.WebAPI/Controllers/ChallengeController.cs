using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.Models;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChallengeController : ControllerBase
    {
        private readonly IChallengeService _challengeService;

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

        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeFullDto>> GetById(long id)
        {
            var challenges = await _challengeService.GetChallengeFullDtoByIdAsync(id);
            return Ok(challenges);
        }

        [HttpPost("test")]
        public ActionResult GetCode([FromBody] CodeRunRequest codeRunRequest)
        {
            _challengeService.SendCodeRunRequest(codeRunRequest);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<ChallengeFullDto>> CreateChallengeAsync(NewChallengeDto challengeDto)
        {
            var challenge = await _challengeService.CreateChallengeAsync(challengeDto);
            return Ok(challenge);
        }

        [HttpPut]
        public async Task<ActionResult<ChallengePreviewDto>> UpdateStar([FromBody] ChallengeStarDto challengeStarDto)
        {
            return Ok(await _challengeService.UpdateAsync(challengeStarDto));
        }

    }
}
