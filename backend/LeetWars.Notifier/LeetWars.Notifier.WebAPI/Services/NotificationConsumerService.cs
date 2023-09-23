﻿using LeetWars.RabbitMQ;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System.Text;
using LeetWars.Notifier.WebAPI.Hubs;
using LeetWars.Notifier.WebAPI.Hubs.Interfaces;
using System.Text.Json;
using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.Common.DTO.CodeFight;

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

                if(notificationDto is null)
                {
                    return;
                }

                await SendNotificationAsync(notificationDto!);

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
            });

            _consumerService.Listen(handler);
        }

        private async Task SendNotificationAsync(NewNotificationDto notificationDto)
        {
            switch (notificationDto.TypeNotification)
            {
                case TypeNotifications.NewChallenge:
                    await _hubContext.Clients.All.SendNotification(notificationDto);
                    break;
                case TypeNotifications.LikeChallenge:
                case TypeNotifications.CodeFightRequest:
                    if (!string.IsNullOrEmpty(notificationDto.ReceiverId))
                    {
                        await _hubContext.Clients.Group(notificationDto.ReceiverId).SendNotification(notificationDto);
                    }
                    break;
                case TypeNotifications.CodeFightStart:
                    if (!string.IsNullOrEmpty(notificationDto.ReceiverId) 
                        && notificationDto.Sender is not null 
                        && notificationDto.Challenge is not null)
                    {
                        var redirectDto = new CodeFightStartDto()
                        {
                            ReceiverId = notificationDto.ReceiverId,
                            SenderId = notificationDto.Sender.Id.ToString(),
                            ChallengeId = notificationDto.Challenge.Id,
                            Notification = notificationDto
                        };

                        await _hubContext.Clients.Groups(redirectDto.ReceiverId, redirectDto.SenderId).StartCodeFight(redirectDto);
                    }
                    break;
                default:
                    await Task.CompletedTask;
                    break;
            }
        }
    }
}