using LeetWars.Notifier.Hubs.Interfaces;
using LeetWars.Notifier.Hubs;
using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using LeetWars.Notifier.WebAPI.Hubs;
using Newtonsoft.Json;
using LeetWars.Notifier.WebAPI.Models;
using LeetWars.Notifier.WebAPI.Interfaces;

namespace LeetWars.Notifier.WebAPI.Services
{
    public class MessageConsumerService : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly IHubManagerHelperService _hubManagerHelperService;

        public MessageConsumerService(
            IConsumerService consumerService,
            IHubManagerHelperService hubManagerHelperService)
        {
            _consumerService = consumerService;
            _hubManagerHelperService = hubManagerHelperService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>(async (model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var request = JsonConvert.DeserializeObject<NotifierMessage>(message);

                if(request != null) 
                {
                    await _hubManagerHelperService.SendMessage(request);
                }

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
