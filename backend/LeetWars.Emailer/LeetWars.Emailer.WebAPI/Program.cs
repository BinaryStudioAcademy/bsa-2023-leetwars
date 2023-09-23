using LeetWars.Core.Common.DTO.Mail;
using LeetWars.Core.Common.Extensions;
using LeetWars.Emailer.Extensions;
using LeetWars.Emailer.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterConsumerServices(builder.Configuration);
builder.Services.AddCustomServices();
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(opt => opt
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

app.UseHttpsRedirection();

app.ConfigureCustomExceptionMiddleware();

app.MapPost("/emailer/sendEmail", (IMailService mailService, MailDto mailDto) =>
{
    return mailService.SendWithValidationCheckAsync(mailDto);
});

app.Run();
