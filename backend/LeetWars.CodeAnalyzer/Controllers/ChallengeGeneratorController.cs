using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.CodeAnalyzer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChallengeGeneratorController: ControllerBase
    {
        private readonly IChallengeGenerator _challengeGenerator;
        public ChallengeGeneratorController(IChallengeGenerator challengeGenerator)
        {
            _challengeGenerator = challengeGenerator;
        }

        [HttpPost]

        public async Task<ActionResult<ChallengeGenerateResponseDto>> GenerateChallenge(ChallengeGenerateRequestDto challengeGenerateRequestDto)
        {
            var result = await _challengeGenerator.GenerateChallenge(challengeGenerateRequestDto);
            return result;

        }
    }
}
