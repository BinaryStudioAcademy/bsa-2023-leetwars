using LeetWars.RabbitMQ.Services;
using LeetWars.RabbitMQ.Settings;
using RabbitMQ.Client;

namespace LeetWars.RabbitMQ;
public class ConsumerService : GeneralConsumerService, IConsumerService
{
    public ConsumerService(IConnection connection, ConsumerSettings settings) : base(connection, settings)
    {
    }
}