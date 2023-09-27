using LeetWars.Core.Common.DTO.Notifications;
using LeetWars.Core.DAL.Enums;
﻿using LeetWars.Core.Common.DTO.CodeFight;
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

                var notificationDto = JsonSerializer.Deserialize<NotificationDto>(message);

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

        private async Task SendNotificationAsync(NotificationDto notificationDto)
        {
            switch (notificationDto.TypeNotification)
            {
                case TypeNotifications.NewChallenge:
                    await SendNotificationToAllUsersAsync(notificationDto);
                    break;

                case TypeNotifications.LikeChallenge:
                    await SendSingleNotificationAsync(notificationDto);
                    break;

                case TypeNotifications.CodeFightRequestStart:
                    await SendCodeFightNotificationToAllAsync(notificationDto);
                    await SendSingleNotificationAsync(notificationDto);
                    break;

                case TypeNotifications.CodeFightRequestEnd:
                    await SendCodeFightNotificationToAllAsync(notificationDto);
                    break;

                case TypeNotifications.CodeFightStart:
                    await StartCodeFightAsync(notificationDto);
                    await SendCodeFightNotificationToAllAsync(notificationDto);
                    break;

                case TypeNotifications.CodeFightEnd:
                    await SendCodeFightResultsAsync(notificationDto);
                    await SendCodeFightNotificationToAllAsync(notificationDto);
                    break;

                default:
                    return;
            }
        }

        private async Task SendNotificationToAllUsersAsync(NotificationDto notificationDto)
        {
            await _hubContext.Clients.All.SendNotificationAsync(notificationDto);
        }

        private async Task SendSingleNotificationAsync(NotificationDto notificationDto)
        {
            if (!string.IsNullOrEmpty(notificationDto.ReceiverId))
            {
                await _hubContext.Clients.Group(notificationDto.ReceiverId).SendNotificationAsync(notificationDto);
            }
        }

        private async Task StartCodeFightAsync(NotificationDto notificationDto)
        {
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

                await _hubContext.Clients.Groups(redirectDto.ReceiverId, redirectDto.SenderId).StartCodeFightAsync(redirectDto);
            }
        }

        private async Task SendCodeFightNotificationToAllAsync(NotificationDto notificationDto)
        {
            if (!string.IsNullOrEmpty(notificationDto.ReceiverId) && notificationDto.Sender is not null)
            {
                var notification = new CodeFightRequestNotificationDto
                {
                    SenderId = notificationDto.Sender.Id,
                    ReceiverId = long.Parse(notificationDto.ReceiverId),
                    Notification = notificationDto
                };

                await _hubContext.Clients.All.CodeFightRequestAsync(notification);
            }
        }

        private async Task SendCodeFightResultsAsync(NotificationDto notificationDto)
        {
            if (!string.IsNullOrEmpty(notificationDto.ReceiverId)
            && notificationDto.Sender is not null)
            {
                await _hubContext.Clients.Groups(notificationDto.Sender.Id.ToString()).WinCodeFightAsync(notificationDto);
                await _hubContext.Clients.Groups(notificationDto.ReceiverId).LoseCodeFightAsync(notificationDto);
            }
        }
    }
}