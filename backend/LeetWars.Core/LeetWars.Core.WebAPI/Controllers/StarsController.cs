using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeStar;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarsController : ControllerBase
    {
        private readonly IStarService _starService;

        public StarsController(IStarService starService)
        {
            _starService = starService;
        }

        [HttpPut]
        public async Task<ActionResult<ChallengeStarDto>> UpdateStar([FromBody] ChallengeStarDto challengeStarDto)
        {
            return Ok(await _starService.Update(challengeStarDto));
        }
    }
}
