using AutoMapper;
using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.Common.DTO.ChallengeGenerate;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using Newtonsoft.Json;

namespace LeetWars.CodeAnalyzer.Services
{
    public class ChallengeGenerator : IChallengeGenerator
    {
        private readonly IOpenAiSettings _openAiSettings;
        private readonly ICompletionService _completionService;
        private readonly IMapper _mapper;

        public ChallengeGenerator(IOpenAiSettings openAiSettings, ICompletionService completionService, IMapper mapper)
        {
            _openAiSettings = openAiSettings;
            _completionService = completionService;
            _mapper = mapper;
        }

        public async Task<ChallengeGenerateResponseDto> GenerateChallenge(ChallengeGenerateRequestDto challengeGenerateRequest)
        {
            string prompt = _openAiSettings.GetChallengePrompt(challengeGenerateRequest);

            var response = await GenerateTextResponse(prompt);

            var challengeResponse = JsonConvert.DeserializeObject<OpenAiChallengeGenerateResponseDto>(response);

            if (challengeResponse == null)
            {
                throw new NotFoundException(nameof(challengeResponse));
            }

            var challengeGenerateResponseDto = _mapper.Map<OpenAiChallengeGenerateResponseDto, ChallengeGenerateResponseDto>(challengeResponse);
            _mapper.Map(challengeGenerateRequest, challengeGenerateResponseDto);

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
