using FluentValidation;
using FluentValidation.Results;
using LeetWars.Core.Common.DTO.Mail;
using LeetWars.Emailer.Interfaces;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace LeetWars.Emailer.Services
{
    public class MailService : IMailService
    {
        private readonly IValidator<MailDto> _validator;
        private readonly IConfiguration _configuration;
        private readonly SendGridClient _sendGridClient;

        public MailService(IConfiguration configuration, IValidator<MailDto> validator)
        {
            _configuration = configuration;
            _validator = validator;
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            _sendGridClient = new SendGridClient(apiKey);
        }

        private async Task SendEmailAsync(MailDto mailDto)
        {
            var senderEmail = new EmailAddress(_configuration["Email"], _configuration["EmailSenderName"]);
            var receiverEmail = new EmailAddress(mailDto.ReceiverEmail);
            var message = MailHelper.CreateSingleEmail(senderEmail, receiverEmail, mailDto.Subject, mailDto.Content, mailDto.Content);
            await _sendGridClient.SendEmailAsync(message);
        }

        public async Task<IResult> SendWithValidationCheckAsync(MailDto mailDto)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(mailDto);
            if (!validationResult.IsValid)
            {
                return Results.ValidationProblem(validationResult.ToDictionary());
            }

            await SendEmailAsync(mailDto);
            return Results.Created($"/{mailDto.ReceiverEmail}", mailDto);
        }
    }
}
