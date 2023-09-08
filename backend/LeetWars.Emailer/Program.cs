using FluentValidation;
using LeetWars.Core.Common.DTO.Mail;
using LeetWars.Emailer.Interfaces;
using LeetWars.Emailer.Services;
using LeetWars.Emailer.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddScoped<IValidator<MailDto>, MailDtoValidator>();
builder.Services.AddCors();
builder.WebHost.UseUrls("http://*:5080");

var app = builder.Build();

app.UseCors(opt => opt
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

app.UseHttpsRedirection();

app.MapPost("/emailer/sendEmail", (IMailService mailService, MailDto mailDto) =>
{
    return mailService.SendWithValidationCheckAsync(mailDto);
});

app.Run();
