using LeetWars.Builder.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task<CodeRunResults> Run(CodeRunRequest request);
    }
}
