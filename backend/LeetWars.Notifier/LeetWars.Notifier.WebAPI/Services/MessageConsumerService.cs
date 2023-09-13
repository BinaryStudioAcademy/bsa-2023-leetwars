using LeetWars.Notifier.Hubs.Interfaces;
using LeetWars.Notifier.Hubs;
using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using Newtonsoft.Json;
using LeetWars.Core.Common.DTO.Notifications;
using Microsoft.Extensions.Logging;

namespace LeetWars.Notifier.WebAPI.Services
{
    public class MessageConsumerService : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly IHubContext<BroadcastHub, IBroadcastHubClient> _hubContext;
        public MessageConsumerService(IConsumerService consumerService, IHubContext<BroadcastHub, IBroadcastHubClient> hubContext)
        {
            _consumerService = consumerService;
            _hubContext = hubContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>(async (model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var parsedMessage = JsonConvert.DeserializeObject<NewNotificationDtoSample>(message);

                await _hubContext.Clients.All.BroadcastMessage(message);

                _consumerService.SetAcknowledge(args.DeliveryTag, false);
            });

            _consumerService.Listen(handler);
            await Task.CompletedTask;
        }
    }
}