using LeetWars.Builder.Models;
using LeetWars.Core.Common.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface ICodeRunManagerService
    {
        Task<CodeRunResults> RunCodeAndTestsAsync(CodeRunRequest request);
    }
}
