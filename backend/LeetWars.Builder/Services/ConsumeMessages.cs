using LeetWars.Builder.Interfaces;
<<<<<<< HEAD
using LeetWars.Builder.RunnerDefaults;
using LeetWars.RabbitMQ;
=======
using LeetWars.Builder.Models;
using LeetWars.RabbitMQ;
using Newtonsoft.Json;
>>>>>>> feature/91-test-execution
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace LeetWars.Builder.Services
{
    public class ConsumeMessages : BackgroundService
    {
        private readonly IConsumerService _consumerService;
<<<<<<< HEAD
        private readonly ISolutionRunnerService _solutionRunnerService;
        private readonly IProducerService _producerService;

        public ConsumeMessages(IConsumerService consumerService, ISolutionRunnerService solutionRunnerService, IProducerService producerService)
        {
            _consumerService = consumerService;
            _solutionRunnerService = solutionRunnerService;
=======
        private readonly ICodeRunManagerService _codeRunManagerService;
        private readonly IProducerService _producerService;
        public ConsumeMessages(IConsumerService consumerService, ICodeRunManagerService codeRunManagerService, IProducerService producerService)
        {
            _consumerService = consumerService;
            _codeRunManagerService = codeRunManagerService;
>>>>>>> feature/91-test-execution
            _producerService = producerService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var handler = new EventHandler<BasicDeliverEventArgs>(async (model, args) =>
            {
                var body = args.Body.ToArray();
                var message = Encoding.UTF8.GetString(body).Replace('"', '\0');

                _solutionRunnerService.RunCodeInContainerAsync(DefaultRunnerImageNames.CSharpImage, "csharp-test-container");
                Console.WriteLine(message);

                var result = await _codeRunManagerService.Run(new CodeRunRequest
                {
                    UserId = 2,
                    ChallengeVersionId = 2,
                    Language = "CSharp",
                    UserCode = "public class Solution\r\n{\r\n    public bool IsNumPrime(int num\r\n    {\r\n        throw new Exception(\"Exception!!!\");\r\n    }\r\n}\r\n",
                    Preloaded = "",
                    Tests = "using NUnit.Framework;\r\n\r\n[TestFixture]\r\npublic class Tests\r\n{\r\n    private Solution? _solutionClass;\r\n\r\n    [SetUp]\r\n    public void Setup()\r\n    {\r\n        _solutionClass = new Solution();\r\n    }\r\n\r\n    [Test]\r\n    public void IsPrime_InputIs1_ReturnFalse()\r\n    {\r\n        var result = _solutionClass.IsNumPrime(2);\r\n\r\n        Assert.IsFalse(result, \"1 should not be prime\");\r\n    }\r\n}"
                });

                var jsonResult = JsonConvert.SerializeObject(result);

                _consumerService.SetAcknowledge(args.DeliveryTag, true);
<<<<<<< HEAD
=======

>>>>>>> feature/91-test-execution
                _producerService.Send("Hello Mario", ExchangeType.Direct);
            });

            _consumerService.Listen(handler);
            return Task.CompletedTask;
        }
    }
}
