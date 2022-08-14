namespace Taxually.Core.Ports.Outbound
{
    public interface IQueueService
    {
        Task EnqueueAsync<TPayload>(string queueName, TPayload payload);
    }
}
