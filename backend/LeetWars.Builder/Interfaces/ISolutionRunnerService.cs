namespace LeetWars.Builder.Interfaces
{
    public interface ISolutionRunnerService : IDisposable
    {
        Task RunCodeAsync(string imagename, string containername);
    }
}
