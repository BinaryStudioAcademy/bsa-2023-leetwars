using LeetWars.Builder.DTO;
using LeetWars.Builder.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task<string> RunSolutionBuild(ContainerDataDto data);
        Task<TestsOutput?> RunSolutionTestsAsync(ContainerDataDto data);
    }
}
