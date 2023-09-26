using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeRequest;

namespace LeetWars.CodeAnalyzer.Interfaces
{
    public interface IOpenAiSettings
    {
        string GetCodeAnalysisPrompt(string languageName, string codeListing);
        string GetChallengePrompt(ChallengeGenerateRequestDto challengeGenerateRequestDto);
    }
}
