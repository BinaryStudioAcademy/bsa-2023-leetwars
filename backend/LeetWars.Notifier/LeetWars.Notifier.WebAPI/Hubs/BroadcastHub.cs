using Microsoft.AspNetCore.SignalR;
using LeetWars.Notifier.Hubs.Interfaces;

namespace LeetWars.Notifier.Hubs
{
    public class BroadcastHub : Hub<IBroadcastHubClient>
    {
    }
}