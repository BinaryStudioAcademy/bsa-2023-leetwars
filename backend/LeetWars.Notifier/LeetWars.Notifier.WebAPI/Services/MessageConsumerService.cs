using LeetWars.Notifier.Hubs.Interfaces;
using LeetWars.Notifier.Hubs;
using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using LeetWars.Notifier.WebAPI.DTO;

namespace LeetWars.Notifier.WebAPI.Services
{
    public class MessageConsumerService : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly IHubContext<BroadcastHub, IBroadcastHubClient> _hubContext;

        public MessageConsumerService(IConsumerService consumerService, IHubContext<BroadcastHub, IBroadcastHubClient> hubContext)
        {
            _hubContext = hubContext;
            _consumerService = consumerService; 
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            var handler = new EventHandler<BasicDeliverEventArgs>(async (model, args) =>
            {
                var body = args.Body.ToArray();

                var message = Encoding.UTF8.GetString(body);

                var dataToSend = JsonConvert.DeserializeObject<SignalRDto>(message);

                if(dataToSend != null)
                {
                    await _hubContext.Clients.Client(dataToSend.ConnectionID).BroadcastMessage(dataToSend.JsonEntityToSend);
                }

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }
    }
}
