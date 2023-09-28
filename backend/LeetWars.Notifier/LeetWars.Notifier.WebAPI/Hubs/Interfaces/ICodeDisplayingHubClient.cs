using LeetWars.Notifier.WebAPI.Models;

namespace LeetWars.Notifier.WebAPI.Hubs.Interfaces;

public interface ICodeDisplayingHubClient
{
    Task BroadcastMessageAsync(CodeRunResults runResults);
    Task BroadcastSubmitResultMessage(CodeSubmitResult codeSubmitResult);
}
