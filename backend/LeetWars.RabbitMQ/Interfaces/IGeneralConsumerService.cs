using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client.Events;

namespace LeetWars.RabbitMQ.Interfaces;
public interface IGeneralConsumerService : IDisposable
{
    void Listen(EventHandler<BasicDeliverEventArgs> messageReceivedHandler);
    void SetAcknowledge(ulong deliveryTag, bool processed);
}
