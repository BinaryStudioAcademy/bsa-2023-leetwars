namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task<string?> RunCodeInContainerAsync(string imageName, string containerName);
    }
}
