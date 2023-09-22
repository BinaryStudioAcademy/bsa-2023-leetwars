using LeetWars.RabbitMQ.Interfaces;
using LeetWars.RabbitMQ.Settings;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ.Services;
public class NotifierCodeConsumerService : GeneralConsumerService, INotifierCodeConsumerService
{
    public NotifierCodeConsumerService(IConnection connection, RabbitMQCodeConsumerSettings settings) : base(connection, settings)
    {
    }
}
