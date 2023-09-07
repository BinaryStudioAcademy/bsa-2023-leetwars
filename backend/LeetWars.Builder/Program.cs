using LeetWars.Builder.Services;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.RunnerDefaults;
using LeetWars.Builder.Extensions;

var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD
builder.Services.RegisterProduceMessagesServices(builder.Configuration);
builder.Services.AddRabbitMqServices(builder.Configuration);
builder.Services.AddScoped<IMessageSenderService, MessageSenderService>();
builder.Services.AddHostedService<ConsumeMessages>();
=======
//builder.Services.RegisterProduceMessagesServices(builder.Configuration);
//builder.Services.AddHostedService<ConsumeMessages>();
>>>>>>> feature/91-test-execution
builder.Services.AddSingleton<ISolutionRunnerService, SolutionRunnerService>();

var app = builder.Build();

app.MapGet("/", () => "Hello, world!");

<<<<<<< HEAD
//Test
//app.MapGet("/docker/csharp", () => new SolutionRunnerService().RunCodeInContainerAsync(DefaultRunnerImageNames.CSharpImage, "csharp-test-container"));
=======
////Test
app.MapGet("/docker/csharp", () => new SolutionRunnerService().RunCodeInContainerAsync("csharptestrunner1", "csharp-testing-container1"));
>>>>>>> feature/91-test-execution

//app.MapGet("/docker/js", () => new SolutionRunnerService().RunCodeInContainerAsync(DefaultRunnerImageNames.JSImage, "js-test-container"));

app.Run();
