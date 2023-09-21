using LeetWars.Notifier.WebAPI.Models;

namespace LeetWars.Notifier.WebAPI.Hubs.Interfaces;

public interface ICodeDisplayingHubClient
{
    Task BroadcastMessage(CodeRunResults runResults);
}
