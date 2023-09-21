namespace LeetWars.Notifier.WebAPI.Hubs.Interfaces;

public interface ICodeDisplayingHubClient
{
    Task BroadcastMessage(string msg);
}
