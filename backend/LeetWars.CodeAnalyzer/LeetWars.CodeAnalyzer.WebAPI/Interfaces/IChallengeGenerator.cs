using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;

namespace LeetWars.CodeAnalyzer.Interfaces
{
    public interface IChallengeGenerator
    {
        Task<ChallengeGenerateResponseDto> GenerateChallenge(ChallengeGenerateRequestDto challengeGenerateRequest);
    }
}
