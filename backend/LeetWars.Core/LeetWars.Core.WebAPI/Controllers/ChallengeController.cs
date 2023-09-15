using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.SortingModel;
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
        public async Task<ActionResult<ChallengePreviewDto>> GetAllAsync([FromQuery] ChallengesFiltersDto filters, [FromQuery] PageSettingsDto page, [FromQuery] SortingModel sortingModel)
        {
            var challenges = await _challengeService.GetChallengesAsync(filters, page, sortingModel);

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
        public ActionResult TestCode([FromBody] CodeRunRequestDto codeRunRequest)
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

        [HttpPut("edit")]
        public async Task<ActionResult<ChallengePreviewDto>> EditChallenge([FromBody] ChallengeEditDto challengeEditDto)
        {
            return Ok(await _challengeService.EditChallengeAsync(challengeEditDto));
        }

        [HttpPut]
        public async Task<ActionResult<ChallengePreviewDto>> UpdateStar([FromBody] ChallengeStarDto challengeStarDto)
        {
            return Ok(await _challengeService.UpdateStarAsync(challengeStarDto));
        }
    }
}
