using LeetWars.Builder.Services;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterProduceMessagesServices(builder.Configuration);

builder.Services.AddRabbitMqServices(builder.Configuration);

builder.Services.AddHostedService<ConsumeMessages>();

builder.Services.RegisterTestRunnerServices(builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello, world!");

app.Run();
