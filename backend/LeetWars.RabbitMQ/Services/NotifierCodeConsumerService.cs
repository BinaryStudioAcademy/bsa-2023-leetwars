using LeetWars.RabbitMQ.Interfaces;
using LeetWars.RabbitMQ.Settings;
using RabbitMQ.Client;

namespace LeetWars.RabbitMQ.Services;
public class NotifierCodeConsumerService : GeneralConsumerService, INotifierCodeConsumerService
{
    public NotifierCodeConsumerService(IConnection connection, RabbitMQCodeConsumerSettings settings) : base(connection, settings)
    {
    }
}
