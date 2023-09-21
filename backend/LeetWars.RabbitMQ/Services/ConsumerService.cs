using LeetWars.RabbitMQ.Services;
using LeetWars.RabbitMQ.Settings;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ;
public class ConsumerService : GeneralConsumerService, IConsumerService
{
    public ConsumerService(IConnection connection, IOptions<ConsumerSettings> settings) : base(connection, settings)
    {
    }
}