using LeetWars.Builder.Services;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.RunnerDefaults;
using LeetWars.Builder.Extensions;

var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD
<<<<<<< HEAD
builder.Services.RegisterProduceMessagesServices(builder.Configuration);
builder.Services.AddRabbitMqServices(builder.Configuration);
builder.Services.AddScoped<IMessageSenderService, MessageSenderService>();
builder.Services.AddHostedService<ConsumeMessages>();
=======
//builder.Services.RegisterProduceMessagesServices(builder.Configuration);
//builder.Services.AddHostedService<ConsumeMessages>();
>>>>>>> feature/91-test-execution
=======
builder.Services.RegisterProduceMessagesServices(builder.Configuration);

builder.Services.AddRabbitMqServices(builder.Configuration);

builder.Services.AddHostedService<ConsumeMessages>();

builder.Services.AddTransient<IMessageSenderService, MessageSenderService>();

>>>>>>> feature/91-test-execution
builder.Services.AddSingleton<ISolutionRunnerService, SolutionRunnerService>();

builder.Services.AddTransient<ICodeRunManagerService, CodeRunManagerService>();



var app = builder.Build();

app.MapGet("/", () => "Hello, world!");

<<<<<<< HEAD
//Test
//app.MapGet("/docker/csharp", () => new SolutionRunnerService().RunCodeInContainerAsync(DefaultRunnerImageNames.CSharpImage, "csharp-test-container"));
=======
////Test
app.MapGet("/docker/csharp", () => new SolutionRunnerService().RunCodeInContainerAsync("csharptestrunner1", "csharp-testing-container1"));
>>>>>>> feature/91-test-execution

<<<<<<< HEAD
//app.MapGet("/docker/js", () => new SolutionRunnerService().RunCodeInContainerAsync(DefaultRunnerImageNames.JSImage, "js-test-container"));
=======
app.MapGet("/docker/csharp1", () => new CodeRunManagerService(new SolutionRunnerService()).Run(new LeetWars.Builder.Models.CodeRunRequest
                                                                                                                            {
                                                                                                                                UserId = 2,
                                                                                                                                ChallengeVersionId = 2,
                                                                                                                                Language = "CSharp",
                                                                                                                                UserCode = "public class Solution\r\n{\r\n    public bool IsNumPrime(int num\r\n    {\r\n        throw new Exception(\"Exception!!!\");\r\n    }\r\n}\r\n",
                                                                                                                                Preloaded = "",
                                                                                                                                Tests = "using NUnit.Framework;\r\n\r\n[TestFixture]\r\npublic class Tests\r\n{\r\n    private Solution? _solutionClass;\r\n\r\n    [SetUp]\r\n    public void Setup()\r\n    {\r\n        _solutionClass = new Solution();\r\n    }\r\n\r\n    [Test]\r\n    public void IsPrime_InputIs1_ReturnFalse()\r\n    {\r\n        var result = _solutionClass.IsNumPrime(2);\r\n\r\n        Assert.IsFalse(result, \"1 should not be prime\");\r\n    }\r\n}"
                                                                                                                            }));

app.MapGet("/docker/js", () => new SolutionRunnerService().RunCodeInContainerAsync(DefaultRunnerImageNames.JSImage, "js-test-container"));
>>>>>>> feature/91-test-execution

app.Run();
