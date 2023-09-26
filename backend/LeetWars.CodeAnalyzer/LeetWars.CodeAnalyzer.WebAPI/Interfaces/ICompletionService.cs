using OpenAI_API.Chat;

namespace LeetWars.CodeAnalyzer.Interfaces
{
    public interface ICompletionService
    {
        /// <summary>
        /// Send request to ChatGPT
        /// </summary>
        /// <param name="prompt">Request text</param>
        /// <returns>Response from chatGPT</returns>
        Task<ChatResult> CreateCompletionAsync(string prompt);
    }
}
