using LeetWars.Notifier.Hubs.Interfaces;
using LeetWars.Notifier.Hubs;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using LeetWars.Notifier.WebAPI.Hubs;
using LeetWars.Notifier.WebAPI.Interfaces;
using LeetWars.Notifier.WebAPI.Models;
using Microsoft.AspNetCore.SignalR;
using LeetWars.Notifier.WebAPI.Models.Helpers;
using Newtonsoft.Json;
using System.Text;

namespace LeetWars.Notifier.WebAPI.Helpers;

public class HubManagerHelperService : IHubManagerHelperService
{
    private readonly IHubContext<BroadcastHub, IBroadcastHubClient> _broadcastHubContext;
    private readonly IHubContext<CodeDisplayingHub, ICodeDisplayingHubClient> _codeDisplayingHubContext;

    public HubManagerHelperService(IHubContext<BroadcastHub, IBroadcastHubClient> broadcastHubContext, IHubContext<CodeDisplayingHub, ICodeDisplayingHubClient> codeDisplayingHubContext)
    {
        _broadcastHubContext = broadcastHubContext;
        _codeDisplayingHubContext = codeDisplayingHubContext;
    }

    public async Task SendMessage(NotifierMessage message)
    {
        var runResult = JsonConvert.DeserializeObject<CodeRunResults>(message.Message);

        if(runResult != null )
        {
            switch (message.HubName)
            {
                case HubNames.broadcastHubName:
                    await _broadcastHubContext.Clients.All.BroadcastMessage(message.Message);
                    break;
                case HubNames.codeDisplayingHubName:
                    await _codeDisplayingHubContext.Clients.Client(runResult.UserConnectionId).BroadcastMessage(message.Message);
                    break;
                default:
                    return;
            }
        }
    }
}
