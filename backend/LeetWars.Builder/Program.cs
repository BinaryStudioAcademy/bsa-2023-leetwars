using LeetWars.Builder.Services;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterProduceMessagesServices(builder.Configuration);

builder.Services.AddRabbitMqServices(builder.Configuration);

builder.Services.AddHostedService<ConsumeMessages>();

builder.Services.AddSingleton<IMessageSenderService, MessageSenderService>();

builder.Services.AddTransient<ISolutionRunnerService, SolutionRunnerService>();

builder.Services.AddTransient<ICodeRunManagerService, CodeRunManagerService>();

builder.Services.AddSingleton<ITarManagementService, TarManagementService>();

builder.Services.AddSingleton<IXmlTestResultParserService, XmlTestResultParserService>();

var app = builder.Build();

app.MapGet("/", () => "Hello, world!");

app.Run();
