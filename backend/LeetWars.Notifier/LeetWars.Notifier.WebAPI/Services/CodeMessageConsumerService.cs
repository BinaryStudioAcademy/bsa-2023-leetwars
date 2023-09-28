using LeetWars.Notifier.WebAPI.Hubs;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using LeetWars.Notifier.WebAPI.Models;
using LeetWars.RabbitMQ.Interfaces;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using LeetWars.Notifier.WebAPI.Helpers;

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
            _consumerService.SetAcknowledge(args.DeliveryTag, true);
            
            var body = args.Body.ToArray();

            var message = Encoding.UTF8.GetString(body);

            var isCodeRunResult = JsonConvertingHelper.TryDeserialize<CodeRunResults>(message, out var codeRunResult);

            if (isCodeRunResult && codeRunResult is not null)
            {
                await _codeDisplayingHubContext.Clients.Group(codeRunResult.UserConnectionId).BroadcastMessageAsync(codeRunResult);
                return;
            }
            
            var isCodeSubmitResult = JsonConvertingHelper.TryDeserialize<CodeSubmitResult>(message, out var codeSubmitResult);
            
            if (isCodeSubmitResult && codeSubmitResult is not null)
            {
                await _codeDisplayingHubContext.Clients.Group(codeSubmitResult.CodeRunResult.UserConnectionId)
                    .BroadcastSubmitResultMessage(codeSubmitResult);
            }
        });

        _consumerService.Listen(handler);

        return Task.CompletedTask;
    }
}
