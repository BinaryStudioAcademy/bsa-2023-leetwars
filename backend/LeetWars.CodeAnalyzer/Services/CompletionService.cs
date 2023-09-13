using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.OpenAISettings;
using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;

namespace LeetWars.CodeAnalyzer.Services
{
    public class CompletionService : ICompletionService
    {
        private readonly OpenAIAPI _openAiApi;

        public CompletionService(OpenAIAPI api)
        {
            _openAiApi = api;
        }

        public async Task<CompletionResult> CreateCompletionAsync(string prompt)
        {
            var request = new CompletionRequest()
            {
                Prompt = prompt,
                Model = Model.ChatGPTTurbo,
                MaxTokens = OpenAiCompletionSettings.MaxTokens,
                Temperature = OpenAiCompletionSettings.Temperature,
                PresencePenalty = OpenAiCompletionSettings.PresencePenalty,
                FrequencyPenalty = OpenAiCompletionSettings.FrequencyPenalty,
            };

            return await _openAiApi.Completions.CreateCompletionAsync(request);
        }
    }
}
