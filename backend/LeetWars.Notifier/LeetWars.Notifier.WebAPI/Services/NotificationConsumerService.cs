using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Notifier.WebAPI.Hubs;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

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

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>(async (model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                var notificationDto = JsonSerializer.Deserialize<NewNotificationDto>(message);

                if (notificationDto is null)
                {
                    return;
                }

                await SendNotificationAsync(notificationDto!);

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);

            return Task.CompletedTask;
        }

        private async Task SendNotificationAsync(NewNotificationDto notificationDto)
        {
            switch (notificationDto.TypeNotification)
            {
                case TypeNotifications.NewChallenge:
                    await _hubContext.Clients.All.SendNotificationAsync(notificationDto);
                    break;
                case TypeNotifications.LikeChallenge:
                    if (!string.IsNullOrEmpty(notificationDto.ReceiverId))
                    {
                        await _hubContext.Clients.Group(notificationDto.ReceiverId).SendNotificationAsync(notificationDto);
                    }
                    break;
                default:
                    await Task.CompletedTask;
                    break;
            }
        }
    }
}
