namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService : IDisposable
    {
        Task RunCodeInContainerAsync(string imagename, string containername);
    }
}
