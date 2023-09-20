using RabbitMQ.Client.Events;
﻿using LeetWars.Notifier.Hubs.Interfaces;
using LeetWars.Notifier.Hubs;
using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using System.Text;

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
                _consumerService.SetAcknowledge(args.DeliveryTag, true);

                var body = args.Body.ToArray();

                var message = Encoding.UTF8.GetString(body);

                await _hubContext.Clients.All.BroadcastMessage(message);

            });

            _consumerService.Listen(handler);

            await Task.CompletedTask;
        }
    }
}