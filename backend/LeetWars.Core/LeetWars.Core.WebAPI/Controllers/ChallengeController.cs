using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.CodeFight;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.SortingModel;
using LeetWars.Core.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using LeetWars.Core.BLL.Services;
using LeetWars.Core.Common.DTO.User;

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
            var challengeLevels = await _challengeService.GetChallengeLevelsAsync();

            return Ok(challengeLevels);
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
            await _challengeService.CreateChallengeAsync(challengeDto);
            return NoContent();
        }

        [HttpPost("codefightrequest")]
        public async Task<ActionResult<List<UserDto>>> SendCodeFightRequestAsync([FromBody] CodeFightRequestDto requestDto)
        {
            var users = await _challengeService.SendCodeFightRequestAsync(requestDto);

            return Ok(users);
        }

        [HttpPost("codefightrequeststart")]
        public async Task<ActionResult> SendCodeFightRequestStartAsync([FromBody] NewNotificationDto notification)
        {
            await _challengeService.SendCodeFightRequestStartAsync(notification);

            return NoContent();
        }

        [HttpPost("codefightrequestend")]
        public async Task<ActionResult> SendCodeFightRequestEndAsync([FromBody] NewNotificationDto notification)
        {
            await _challengeService.SendCodeFightRequestEndAsync(notification);

            return NoContent();
        }

        [HttpPost("codefightstart")]
        public async Task<ActionResult> SendCodeFightStartAsync([FromBody] NewNotificationDto notificationDto)
        {
            await _challengeService.SendCodeFightStartAsync(notificationDto);

            return NoContent();
        }

        [HttpPost("codefightend")]
        public async Task<ActionResult> SendCodeFightEndAsync([FromBody] CodeFightEndDto codeFightEndDto)
        {
            await _challengeService.SendCodeFightEndAsync(codeFightEndDto);

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

        [HttpPut("codeFightStatus")]
        public async Task<ActionResult<List<UserDto>>> UpdateUserCodeFightStatusAsync([FromBody] UserCodeFightDto userCodeFightDto)
        {
            var users = await _challengeService.UpdateCodeFightStatusAsync(userCodeFightDto);

            return Ok(users);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteChallenge(long id)
        {
            await _challengeService.DeleteChallengeAsync(id);
            return NoContent();
        }
    }
}
