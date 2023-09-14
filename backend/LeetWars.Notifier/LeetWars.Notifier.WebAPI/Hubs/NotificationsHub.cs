using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace LeetWars.Notifier.WebAPI.Hubs
{
    public class NotificationsHub :  Hub<INotificationsHubClient>
    {
        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
    }
}
