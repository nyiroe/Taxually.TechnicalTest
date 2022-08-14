using System.Xml.Serialization;
using Taxually.Core.Ports.Inbound;
using Taxually.Core.Ports.Inbound.Models;
using Taxually.Core.Ports.Outbound;

namespace Taxually.Core.Services.VatRegistrationWorkers
{
    public class DeVatRegistrationWorker : IVatRegistrationWorker
    {
        // may be put into some configuration
        private const string QueueName = "vat-registration-xml";

        private readonly IQueueService _queueService;

        public DeVatRegistrationWorker(IQueueService queueService)
        {
            _queueService = queueService;
        }

        public async Task RegisterVatAsync(VatRegistrationRequest request)
        {
            // may be further refactored
            using (var stringwriter = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(VatRegistrationRequest));
                serializer.Serialize(stringwriter, request);
                var xml = stringwriter.ToString();

                await _queueService.EnqueueAsync(QueueName, xml);
            }
        }
    }
}
