namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService
    {
        Task RunCodeInContainerAsync(string imageName, string containerName);
    }
}
