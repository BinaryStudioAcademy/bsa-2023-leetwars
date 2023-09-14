using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ.Services
{
    public static class ConsumerSetupHelperService
    {
        public static void ListenSetup(EventHandler<BasicDeliverEventArgs> messageReceivedHandler, IModel channel, ConsumerSettings settings)
        {
            SetupChannel(channel, settings);

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += messageReceivedHandler;

            if (settings.SequentialFetch)
            {
                channel.BasicQos(0, 1, false);
            }
            channel.BasicConsume(settings.QueueName, settings.AutoAcknowledge, consumer);
        }

        public static void ListenAsyncSetup(AsyncEventHandler<BasicDeliverEventArgs> messageReceivedHandler, IModel channel, ConsumerSettings settings)
        {
            SetupChannel(channel, settings);

            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.Received += messageReceivedHandler;

            if (settings.SequentialFetch)
            {
                channel.BasicQos(0, 1, false);
            }

            channel.BasicConsume(settings.QueueName, settings.AutoAcknowledge, consumer);
        }

        public static void SetAcknowledgeSetup(ulong deliveryTag, bool processed, IModel channel)
        {
            if (processed)
            {
                channel.BasicAck(deliveryTag, false);
            }
            else
            {
                channel.BasicNack(deliveryTag, false, true);
            }
        }

        private static void SetupChannel(IModel channel, ConsumerSettings settings)
        {
            channel.ExchangeDeclare(settings.ExchangeName, settings.ExchangeType);
            channel.QueueDeclare(settings.QueueName, true, false, false);
            channel.QueueBind(settings.QueueName, settings.ExchangeName, settings.RoutingKey);
        }

    }
}
