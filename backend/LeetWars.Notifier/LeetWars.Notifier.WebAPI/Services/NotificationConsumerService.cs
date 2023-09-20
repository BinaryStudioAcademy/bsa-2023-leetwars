using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using LeetWars.Notifier.WebAPI.Hubs;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using System.Text.Json;
using LeetWars.Core.Common.DTO.Notifications;

namespace LeetWars.Notifier.WebAPI.Services
{
    public class NotificationConsumerService : BackgroundService
    {
        private readonly IConsumerService _consumerService;
        private readonly IHubContext<NotificationsHub, INotificationsHubClient> _hubContext;
        public NotificationConsumerService(IConsumerService consumerService, IHubContext<NotificationsHub, INotificationsHubClient> hubContext)
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

                var notificationDto = JsonSerializer.Deserialize<NewNotificationDto>(message);

                if (notificationDto != null)
                {
                    await SendNotificationAsync(notificationDto);
                }

                _consumerService.SetAcknowledge(args.DeliveryTag, false);
            });

            _consumerService.Listen(handler);
            await Task.CompletedTask;
        }

        private async Task SendNotificationAsync(NewNotificationDto notificationDto)
        {
            await (notificationDto?.TypeNotification switch
            {
                TypeNotifications.NewChallenge => 
                    _hubContext.Clients.All.SendNotification(notificationDto),
                TypeNotifications.LikeChallenge when notificationDto.ReceiverId != null => 
                    _hubContext.Clients.Group(notificationDto.ReceiverId).SendNotification(notificationDto),
                _ => Task.CompletedTask
            });
        }
    }
}
