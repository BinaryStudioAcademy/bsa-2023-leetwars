using FluentValidation;
using LeetWars.Core.Common.DTO.Mail;

namespace LeetWars.Emailer.Validators
{
    public class MailDtoValidator : AbstractValidator<MailDto>
    {
        public MailDtoValidator()
        {
            RuleFor(e => e.ReceiverEmail)
                .NotEmpty()
                .WithMessage("Email is required")
                .EmailAddress()
                .WithMessage("Invalid email format");
            RuleFor(e => e.Subject)
                .NotEmpty()
                .WithMessage("Subject is required")
                .MaximumLength(100)
                .WithMessage("Max size of subject length is 100");
            RuleFor(e => e.Content)
                .NotEmpty()
                .WithMessage("Content is required");
        }
    }
}
