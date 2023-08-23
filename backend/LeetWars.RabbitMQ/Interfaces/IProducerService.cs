namespace LeetWars.RabbitMQ;
public interface IProducerService : IDisposable
{
    void Send(object obj, string? type);
    void Send(string message, string? type);
}