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

        public CompletionService(OpenAIAPI api)
        {
            _openAiApi = api;
        }

        public async Task<ChatResult> CreateCompletionAsync(string prompt)
        {
            var request = new ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                MaxTokens = OpenAiCompletionSettings.MaxTokens,
                Temperature = OpenAiCompletionSettings.Temperature,
                PresencePenalty = OpenAiCompletionSettings.PresencePenalty,
                FrequencyPenalty = OpenAiCompletionSettings.FrequencyPenalty,
                Messages = new ChatMessage[]
                {
                    new ChatMessage(ChatMessageRole.User, prompt)
                }
            };

            return await _openAiApi.Chat.CreateChatCompletionAsync(request);
        }
    }
}
