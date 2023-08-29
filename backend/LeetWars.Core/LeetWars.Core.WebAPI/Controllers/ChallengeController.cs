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
        public ChallengeController(IChallengeService challengeService, IMessageSenderService messageSender)
        {
            _challengeService = challengeService;
            _messageSender = messageSender;
        }

        [HttpGet]
        public async Task<ActionResult<ChallengePreviewDto>> GetAllAsync([FromQuery] ChallengesFiltersDto filters)
        {
            var challenges = await _challengeService.GetChallengesAsync(filters);
            return Ok(challenges);
        }

        [HttpGet("sendMessage")]
        public IActionResult Get()
        {
            _messageSender.SendMessageToRabbitMQ("Hello, world!");
            return Ok();
        }

        private readonly IChallengeService _challengeService;
        private readonly IMessageSenderService _messageSender;
    }
}
