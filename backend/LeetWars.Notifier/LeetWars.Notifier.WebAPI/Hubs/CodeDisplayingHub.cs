using LeetWars.Notifier.Hubs.Interfaces;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace LeetWars.Notifier.WebAPI.Hubs;

public class CodeDisplayingHub : Hub<ICodeDisplayingHubClient>
{
    public async Task OnConnectAsync(string currentUserId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, currentUserId);
    }
}
