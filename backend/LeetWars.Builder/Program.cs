using LeetWars.Builder.Extensions;
using LeetWars.Builder.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterProduceMessagesServices(builder.Configuration);
builder.Services.AddHostedService<ConsumeMessages>();

var app = builder.Build();

app.MapGet("/", () => "Hello, world!");

app.Run();
