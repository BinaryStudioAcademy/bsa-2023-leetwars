using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeLevel;
using LeetWars.Core.Common.DTO.ChallengeStar;
using LeetWars.Core.Common.DTO.CodeRunRequest;
using LeetWars.Core.Common.DTO.Filters;
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

        /// <summary>
        /// Get all created challenges
        /// </summary>
        /// <param name="filters">Filters</param>
        /// <param name="page">Paging</param>
        /// <param name="sortingModel">Sorting settings</param>
        /// <returns>Collection of challenges</returns>
        [HttpGet]
        public async Task<ActionResult<ICollection<ChallengePreviewDto>>> GetAllAsync([FromQuery] ChallengesFiltersDto filters, [FromQuery] PageSettingsDto page, [FromQuery] SortingModel sortingModel)
        {
            var challenges = await _challengeService.GetChallengesAsync(filters, page, sortingModel);

            return Ok(challenges);
        }

        /// <summary>
        /// Get challenge suggestion
        /// </summary>
        /// <param name="settings">Suggestion settings</param>
        /// <returns>Suggested challenge</returns>
        [HttpGet("suggestion")]
        public async Task<ActionResult<ChallengePreviewDto>> GetChallengeSuggestionAsync([FromQuery] SuggestionSettingsDto settings)
        {
            var challenge = await _challengeService.GetChallengeSuggestionAsync(settings);

            return Ok(challenge);
        }

        /// <summary>
        /// Get challenge by id
        /// </summary>
        /// <param name="id">Id of the challenge</param>
        /// <returns>Full challenge</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeFullDto>> GetByIdAsync(long id)
        {
            var challenges = await _challengeService.GetChallengeFullDtoByIdAsync(id);

            return Ok(challenges);
        }

        /// <summary>
        /// Create new challenge
        /// </summary>
        /// <param name="challengeDto">Challenge to create</param>
        [HttpPost]
        public async Task<ActionResult<ChallengeFullDto>> CreateChallengeAsync(NewChallengeDto challengeDto)
        {
            var challenge = await _challengeService.CreateChallengeAsync(challengeDto);

            return Ok(challenge);
        }

        /// <summary>
        /// Get challenge levels
        /// </summary>
        /// <returns></returns>
        [HttpGet("levels")]
        public async Task<ActionResult<List<ChallengeLevelDto>>> GetChallengeLevelsAsync()
        {
            var challengeLevels = await _challengeService.GetChallengeLevelsAsync();

            return Ok(challengeLevels);
        }

        /// <summary>
        /// Test code
        /// </summary>
        /// <param name="codeRunRequest">Code run settings</param>
        [HttpPost("test")]
        public ActionResult TestCode([FromBody] CodeRunRequestDto codeRunRequest)
        {
            _challengeService.SendCodeRunRequest(codeRunRequest);

            return Ok();
        }

        /// <summary>
        /// Update stars on challenge
        /// </summary>
        /// <param name="challengeStarDto">Star on challenge</param>
        /// <returns>Challenge with new stars</returns>
        [HttpPut]
        public async Task<ActionResult<ChallengePreviewDto>> UpdateStarAsync([FromBody] ChallengeStarDto challengeStarDto)
        {
            return Ok(await _challengeService.UpdateStarAsync(challengeStarDto));
        }

        /// <summary>
        /// Edit challenge
        /// </summary>
        /// <param name="challengeEditDto">Challenge to edit</param>
        /// <returns>Edited challenge</returns>
        [HttpPut("edit")]
        public async Task<ActionResult<ChallengeFullDto>> EditChallengeAsync([FromBody] ChallengeEditDto challengeEditDto)
        {
            return Ok(await _challengeService.EditChallengeAsync(challengeEditDto));
        }

        /// <summary>
        /// Delete challenge
        /// </summary>
        /// <param name="id">Id of challenge to delete</param>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteChallengeAsync(long id)
        {
            await _challengeService.DeleteChallengeAsync(id);

            return NoContent();
        }
    }
}
