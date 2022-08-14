using Taxually.Core.Ports.Outbound;

namespace Taxually.Adapter.Queue
{
    public class QueueService : IQueueService
    {
        public Task EnqueueAsync<TPayload>(string queueName, TPayload payload)
        {
            // Code to send to message queue removed for brevity
            return Task.CompletedTask;
        }
    }
}
