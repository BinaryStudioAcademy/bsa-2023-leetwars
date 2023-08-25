namespace LeetWars.Builder.Services.Abstract
{
    public interface IProduceMessages
    {
        void Send(object obj);
        void Send(string message);
    }
}
