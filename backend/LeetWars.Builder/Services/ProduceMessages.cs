using LeetWars.Builder.Services.Abstract;
using LeetWars.RabbitMQ;
using RabbitMQ.Client;

namespace LeetWars.Builder.Services
{
    public class ProduceMessages : IProduceMessages
    {
        private readonly IProducerService _producer;

        public ProduceMessages(IProducerService producer)
        {
            _producer = producer;
        }

        public void Send(object obj)
        {
            _producer.Send(obj, ExchangeType.Direct);
        }

        public void Send(string message)
        {
            Send(message as object);
        }
    }
}
