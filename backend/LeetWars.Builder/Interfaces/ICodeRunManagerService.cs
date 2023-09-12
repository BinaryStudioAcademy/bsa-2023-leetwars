using LeetWars.Builder.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface ICodeRunManagerService
    {
        Task<CodeRunResults> RunCodeAndTestsAsync(CodeRunRequest request);
    }
}
