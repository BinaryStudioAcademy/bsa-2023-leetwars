namespace LeetWars.RabbitMQ;
public class ConsumerSettings : ProducerSettings
{
    public bool SequentialFetch { get; set; } = true;
    public bool AutoAcknowledge { get; set; } = false;
}