using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.OpenAISettings;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using LeetWars.Core.Common.DTO.CodeAnalysis;
using Newtonsoft.Json;

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
            string prompt = _openAiSettings.GetChallengePrompt(challengeGenerateRequest);

            var response = await GenerateTextResponse(prompt);



            ChallengeGenerateResponseDto challengeResponse = JsonConvert.DeserializeObject<ChallengeGenerateResponseDto>(response);
            challengeResponse.Title = challengeGenerateRequest.Title;
            challengeResponse.Level = challengeGenerateRequest.Level;
            challengeResponse.Category = challengeGenerateRequest.Category;
            challengeResponse.Tags = challengeGenerateRequest.Tags;
            challengeResponse.Language = challengeGenerateRequest.Language;



            return challengeResponse;


            //return new ChallengeGenerateResponseDto
            //{
            //    Description = response

            //};
        }

        private async Task<string> GenerateTextResponse(string prompt)
        {
            var chatResponse = await _completionService.CreateCompletionAsync(prompt);
            string response = chatResponse.ToString();
            return (response);
        }

        private string CleanResponse(string response)
        {
            if (string.IsNullOrWhiteSpace(response))
            {
                throw new NotFoundException(nameof(ChallengeGenerateRequestDto));
            }
            return response
                .Replace("\n", " ")
                .Replace("\r", " ")
                .Replace("\t", " ");
        }
    }

}
