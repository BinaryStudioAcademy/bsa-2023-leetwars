using LeetWars.Notifier.WebAPI.Hubs;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using LeetWars.Notifier.WebAPI.Models;
using LeetWars.RabbitMQ.Interfaces;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Notifier.WebAPI.Services;

public class CodeMessageConsumerService : BackgroundService
{
    private readonly INotifierCodeConsumerService _consumerService;
    private readonly IHubContext<CodeDisplayingHub, ICodeDisplayingHubClient> _codeDisplayingHubContext;

    public CodeMessageConsumerService(
        INotifierCodeConsumerService consumerService,
        IHubContext<CodeDisplayingHub, ICodeDisplayingHubClient> codeDisplayingHubContext)
    {
        _consumerService = consumerService;
        _codeDisplayingHubContext = codeDisplayingHubContext;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var handler = new EventHandler<BasicDeliverEventArgs>(async (model, args) =>
        {
            var body = args.Body.ToArray();

            var message = Encoding.UTF8.GetString(body);
            var request = JsonConvert.DeserializeObject<CodeRunResults>(message);

            if (request is not null)
            {
                await _codeDisplayingHubContext.Clients.Group(request.UserConnectionId).BroadcastMessageAsync(request);
            }

            _consumerService.SetAcknowledge(args.DeliveryTag, true);
        });

        _consumerService.Listen(handler);

        return Task.CompletedTask;
    }
}
