namespace LeetWars.RabbitMQ.Settings;
public class GeneralConsumerSettings : ProducerSettings
{
    public bool SequentialFetch { get; set; } = true;
    public bool AutoAcknowledge { get; set; } = false;
}
