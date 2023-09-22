using LeetWars.Core.Common.DTO.Mail;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface IEmailSenderService
    {
        void SendEmailMessageToRabbitMQ(MailDto mailDto);
    }
}
