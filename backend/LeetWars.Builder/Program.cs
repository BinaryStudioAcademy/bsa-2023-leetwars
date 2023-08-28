using LeetWars.Builder.Extensions;
using LeetWars.Builder.Services.Abstract;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterProduceMessagesServices(builder.Configuration);

var app = builder.Build();

app.MapGet("/", (IProduceMessages produceMessages) => produceMessages.Send("Hello, world!"));

app.Run();
