using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;
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



            var challengeResponse = JsonConvert.DeserializeObject<OpenAiChallengeGenerateResponseDto>(response);

            if(challengeResponse is null) 
            {
                throw new Exception();
            }

            ChallengeGenerateResponseDto challengeGenerateResponseDto = new ChallengeGenerateResponseDto();

            challengeGenerateResponseDto.Title = challengeGenerateRequest.Title;
            challengeGenerateResponseDto.Level = challengeGenerateRequest.Level;
            challengeGenerateResponseDto.Category = challengeGenerateRequest.Category;
            challengeGenerateResponseDto.Tags = challengeGenerateRequest.Tags;
            challengeGenerateResponseDto.Language = challengeGenerateRequest.Language;
            challengeGenerateResponseDto.Description = challengeResponse.Description;
            challengeGenerateResponseDto.CompleteSolution = challengeResponse.CompleteSolution;
            challengeGenerateResponseDto.InitialSolution = challengeResponse.InitialSolution;
            challengeGenerateResponseDto.TestCases = challengeResponse.Tests;
            challengeGenerateResponseDto.ExampleTestCases = challengeResponse.TestsSubset;

            return challengeGenerateResponseDto;


        }

        private async Task<string> GenerateTextResponse(string prompt)
        {
            var chatResponse = await _completionService.CreateCompletionAsync(prompt);
            string response = chatResponse.ToString();
            return response;
        }
    }
}
