using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.OpenAISettings;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using LeetWars.Core.Common.DTO.CodeAnalysis;

namespace LeetWars.CodeAnalyzer.Services
{
    public class ChallengeGenerator : IChallengeGenerator
    {
        private readonly IOpenAiSettings _openAiSettings;
        private readonly ICompletionService _completionService;

        public ChallengeGenerator(IOpenAiSettings openAiSettings, ICompletionService completionService)
        {
            _openAiSettings = openAiSettings;
            _completionService = completionService;
        }

        public async Task<ChallengeGenerateResponseDto> GenerateChallenge(ChallengeGenerateRequestDto challengeGenerateRequest)
        {
            string prompt = _openAiSettings.GetChallengeGeneratePrompt(challengeGenerateRequest);

            var chatResponse = await _completionService.CreateCompletionAsync(prompt);

            string response = chatResponse.ToString();

            if (string.IsNullOrWhiteSpace(response))
            {
                throw new NotFoundException(nameof(ChallengeGenerateRequestDto));
            }

            return new ChallengeGenerateResponseDto { ChallengeTaskCode = response };


        }
    }

}
