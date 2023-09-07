using LeetWars.Builder.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task<string?> RunCodeInContainerAsync(string imageName, string containerName);
        Task<BuildResult> RunSolutionBuild(string processName, string code);
        Task<string> RunSolutionTests(string processName, string code, string tests);
        Task<CSharpTestOutput> RunCSharpSolutionTests(string containerName, string csharpCode, string csharpTests);
        Task<BuildResult> RunCSharpBuild(string containerName, string csharpCode);
    }
}
