using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.SortingModel;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
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

        [HttpGet("levels")]
        public async Task<ActionResult<ChallengePreviewDto>> GetChallengeLevelsAsync()
        {
            var challengeLevels = await _challengeService.GetChallengesLevelsAsync();

            return Ok(challengeLevels);
        }

        [HttpPost]
        public async Task<ActionResult<ChallengeFullDto>> CreateChallengeAsync(NewChallengeDto challengeDto)
        {
            await _challengeService.CreateChallengeAsync(challengeDto);
            return NoContent();
        }

        [HttpPost("codefightrequest")]
        public async Task<ActionResult<ChallengeFullDto>> SendCodeFightChallengeAsync([FromBody] CodeFightRequestDto requestDto)
        {
            await _challengeService.SendCodeFightRequest(requestDto);
            return NoContent();
        }

        [HttpPost("codefightredirect")]
        public ActionResult<ChallengeFullDto> SendCodeFightRedirectAsync([FromBody] NewNotificationDto notificationDto)
        {
            _challengeService.SendCodeFightRedirect(notificationDto);
            return NoContent();
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
