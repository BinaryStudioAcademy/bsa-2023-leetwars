using LeetWars.Builder.Services;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterConsumeMessagesServices(builder.Configuration);
builder.Services.RegisterProduceMessagesServices(builder.Configuration);
builder.Services.AddHostedService<ConsumeMessages>();
builder.Services.AddSingleton<ISolutionRunnerService, SolutionRunnerService>();
builder.Services.AddTransient<ICodeRunManagerService, CodeRunManagerService>();

var app = builder.Build();

app.MapGet("/", () => "Hello, world!");

app.Run();
