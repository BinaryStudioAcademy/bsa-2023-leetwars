using LeetWars.Builder.DTO;
using LeetWars.Builder.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task<string> RunSolutionBuildAsync(ContainerDataDto data);

        Task<TestsOutput?> RunSolutionTestsAsync(ContainerDataDto data);
    }
}
