using LeetWars.RabbitMQ;
using RabbitMQ.Client.Events;
using System.Text;
using Newtonsoft.Json;
using LeetWars.Notifier.WebAPI.Models;
using LeetWars.Notifier.WebAPI.Interfaces;
using LeetWars.Notifier.WebAPI.Models.Helpers;
using Microsoft.AspNetCore.Rewrite;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using LeetWars.Notifier.WebAPI.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace LeetWars.Notifier.WebAPI.Services
{
    public class MessageConsumerService : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly IHubContext<CodeDisplayingHub, ICodeDisplayingHubClient> _codeDisplayingHubContext;

        public MessageConsumerService(
            IConsumerService consumerService,
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
                var request = JsonConvert.DeserializeObject<CodeRunResults>(message);

                if(request is not null) 
                {
                    await _codeDisplayingHubContext.Clients.Client(request.UserConnectionId).BroadcastMessage(message);
                }
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }
    }
}
