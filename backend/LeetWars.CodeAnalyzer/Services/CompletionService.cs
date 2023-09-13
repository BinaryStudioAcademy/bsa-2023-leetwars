using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.CodeAnalyzer.OpenAISettings;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;

namespace LeetWars.CodeAnalyzer.Services
{
    public class CompletionService : ICompletionService
    {
        private readonly OpenAIAPI _openAiApi;
        private readonly IConfiguration _configuration;

        public CompletionService(OpenAIAPI api, IConfiguration configuration)
        {
            _openAiApi = api;
            _configuration = configuration;
        }

        public async Task<ChatResult> CreateCompletionAsync(string prompt)
        {
            var request = new ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                MaxTokens = int.Parse(_configuration["OpenAPISettings:MaxTokens"]),
                Temperature = double.Parse(_configuration["OpenAPISettings:Temperature"]),
                PresencePenalty = double.Parse(_configuration["OpenAPISettings:PresencePenalty"]),
                FrequencyPenalty = double.Parse(_configuration["OpenAPISettings:FrequencyPenalty"]),
                Messages = new ChatMessage[]
                {
                    new ChatMessage(ChatMessageRole.User, prompt)
                }
            };

            return await _openAiApi.Chat.CreateChatCompletionAsync(request);
        }
    }
}
