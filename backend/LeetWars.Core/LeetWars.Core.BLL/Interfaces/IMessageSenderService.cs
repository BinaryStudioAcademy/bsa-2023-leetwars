namespace LeetWars.Core.BLL.Interfaces
{
    public interface IMessageSenderService
    {
        void SendMessageToRabbitMQ(object obj);
    }
}
