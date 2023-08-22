using LeetWars.Core.WebAPI.RabbitMQ;
using LeetWars.Core.WebAPI;


var builder = WebApplication.CreateBuilder(args);
builder.Configuration
 .SetBasePath(builder.Environment.ContentRootPath)
 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
 .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", reloadOnChange: true, optional: true)
 .AddEnvironmentVariables()
 .Build();

builder.Services.AddScoped<IRabbitMqService, RabbitMqService>();
builder.Services.AddHostedService<ListenerService>();

var app = builder.Build();

app.Run();
