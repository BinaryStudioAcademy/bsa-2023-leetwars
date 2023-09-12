using LeetWars.Builder.DTO;
using LeetWars.Builder.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task<TestsOutput?> RunSolutionTestsAsync(TestingContainerDataDto data);
    }
}
