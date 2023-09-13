using OpenAI_API.Completions;

namespace LeetWars.CodeAnalyzer.Interfaces
{
    public interface ICompletionService
    {
        /// <summary>
        /// Send request to ChatGPT
        /// </summary>
        /// <param name="prompt">Request text</param>
        /// <returns>Response from chatGPT</returns>
        Task<CompletionResult> CreateCompletionAsync(string prompt);
    }
}
