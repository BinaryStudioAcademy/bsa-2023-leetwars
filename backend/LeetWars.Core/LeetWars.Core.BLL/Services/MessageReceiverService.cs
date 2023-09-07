using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetWars.RabbitMQ;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client.Events;

namespace LeetWars.Core.BLL.Services;
public class MessageReceiverService : BackgroundService
{
    //private readonly IConsumerService _consumerService;

    //public MessageReceiverService(IConsumerService consumerService)
    //{
    //    _consumerService = consumerService;
    //}

    //protected override Task ExecuteAsync(CancellationToken stoppingToken)
    //{
    //    var handler = new EventHandler<BasicDeliverEventArgs>((model, args) =>
    //    {
    //        var body = args.Body.ToArray();
    //        var message = Encoding.UTF8.GetString(body);

    //        Console.WriteLine(message);

    //        _consumerService.SetAcknowledge(args.DeliveryTag, true);
    //    });

    //    _consumerService.Listen(handler);
    //    return Task.CompletedTask;
    //}
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        throw new NotImplementedException();
    }
}
