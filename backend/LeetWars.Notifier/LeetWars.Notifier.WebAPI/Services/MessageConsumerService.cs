using LeetWars.Notifier.Hubs.Interfaces;
using LeetWars.Notifier.Hubs;
using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using LeetWars.Notifier.WebAPI.Models;

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

            var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
            {
                var body = args.Body.ToArray();

                var message = Encoding.UTF8.GetString(body);

                var messageObj = JsonConvert.DeserializeObject<CodeRunResults>(message);

                string jsonMessage = JsonConvert.SerializeObject(
                    messageObj,
                    new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }
                );

                _hubContext.Clients.All.BroadcastMessage(jsonMessage);

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }
    }
}
