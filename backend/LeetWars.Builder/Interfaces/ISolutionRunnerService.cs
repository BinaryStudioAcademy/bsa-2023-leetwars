using Microsoft.AspNetCore.Mvc.Razor;

namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task<string> RunSolutionTestsAsync(string processName, string language, string code, string tests, string preloaded);
    }
}
