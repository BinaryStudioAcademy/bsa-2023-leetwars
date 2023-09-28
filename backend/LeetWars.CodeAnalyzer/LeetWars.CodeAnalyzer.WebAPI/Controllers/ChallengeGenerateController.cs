using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.CodeAnalyzer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChallengeGenerateController
    {
        private readonly IChallengeGenerator _challengeGenerator;

        public ChallengeGenerateController(IChallengeGenerator challengeGenerator)
        {
            _challengeGenerator = challengeGenerator;
        }

        [HttpPost]
        public async Task<IActionResult> GenerateChallenge([FromBody] ChallengeGenerateRequestDto challengeGenerateRequestDto)
        {
            var response = await _challengeGenerator.GenerateChallenge(challengeGenerateRequestDto);
            return new JsonResult(response);
        }

    }
}
