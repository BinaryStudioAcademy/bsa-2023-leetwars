using LeetWars.Core.Common.DTO.CodeRunRequest;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IBuilderSenderService
    {
        void SendNotificationToRabbitMQ(CodeRunRequestDto codeRunRequestDto);
    }
}
