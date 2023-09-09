using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.Models;
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
        public async Task<ActionResult<ChallengePreviewDto>> GetAllAsync([FromQuery] ChallengesFiltersDto filters)
        {
            var challenges = await _challengeService.GetChallengesAsync(filters);
            return Ok(challenges);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ChallengeFullDto>> GetById(long id)
        {
            var challenges = await _challengeService.GetChallengeByIdAsync(id);
            return Ok(challenges);
        }

        [HttpPost("test")]
        public ActionResult GetCode([FromBody] CodeRunRequest codeRunRequest)
        {
            _challengeService.SendCodeRunRequest(codeRunRequest);
            return Ok();
        }
    }
}
