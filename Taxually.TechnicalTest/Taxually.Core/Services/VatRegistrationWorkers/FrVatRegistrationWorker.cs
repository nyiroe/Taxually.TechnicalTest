using System.Text;
using Taxually.Core.Ports.Inbound;
using Taxually.Core.Ports.Inbound.Models;
using Taxually.Core.Ports.Outbound;

namespace Taxually.Core.Services.VatRegistrationWorkers
{
    public class FrVatRegistrationWorker : IVatRegistrationWorker
    {
        // may be put into some configuration
        private const string QueueName = "vat-registration-csv";

        private readonly IQueueService _queueService;

        public FrVatRegistrationWorker(IQueueService queueService)
        {
            _queueService = queueService;
        }

        public async Task RegisterVatAsync(VatRegistrationRequest request)
        {
            // may be further refactored
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine("CompanyName,CompanyId");
            csvBuilder.AppendLine($"{request.CompanyName}{request.CompanyId}");
            var csv = Encoding.UTF8.GetBytes(csvBuilder.ToString());

            await _queueService.EnqueueAsync(QueueName, csv);
        }
    }
}
