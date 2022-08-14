using Taxually.Core.Ports.Inbound;
using Taxually.Core.Ports.Inbound.Models;
using Taxually.Core.Ports.Outbound;
using Taxually.Core.Ports.Outbound.Models;

namespace Taxually.Core.Services.VatRegistrationWorkers
{
    public class UkVatRegistrationWorker : IVatRegistrationWorker
    {
        // may be put into some configuration
        private const string Url = "https://api.uktax.gov.uk";

        private readonly IVatRegistrationExternalService _vatRegistrationExternalService;

        public UkVatRegistrationWorker(IVatRegistrationExternalService vatRegistrationExternalService)
        {
            _vatRegistrationExternalService = vatRegistrationExternalService;
        }

        public async Task RegisterVatAsync(VatRegistrationRequest request)
        {
            // some automatic mapping may be used
            var externalRequest = new VatRegistrationExternalRequest
            {
                CompanyId = request.CompanyId,
                CompanyName = request.CompanyName,
                Country = request.Country
            };

            await _vatRegistrationExternalService.RegisterVatAsync(Url, externalRequest);
        }
    }
}
