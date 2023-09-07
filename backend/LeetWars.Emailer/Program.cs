using FluentValidation;
using LeetWars.Core.Common.DTO.Mail;
using LeetWars.Emailer.Interfaces;
using LeetWars.Emailer.Services;
using LeetWars.Emailer.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddScoped<IValidator<MailDto>, MailDtoValidator>();

var app = builder.Build();

app.MapPost("/emailer/sendEmail", (IMailService mailService, MailDto mailDto) =>
{
    return mailService.SendWithValidationCheck(mailDto);
});

app.Run();
