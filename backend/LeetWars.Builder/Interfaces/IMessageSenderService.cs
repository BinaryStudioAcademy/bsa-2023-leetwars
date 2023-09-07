namespace LeetWars.Builder.Interfaces;

public interface IMessageSenderService
{
    void SendMessageToRabbitMQ(object obj);
}
