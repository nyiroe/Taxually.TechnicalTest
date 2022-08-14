using Taxually.Adapter.UK.Interfaces;
using Taxually.Core.Ports.Outbound;
using Taxually.Core.Ports.Outbound.Models;

namespace Taxually.Adapter.UK
{
    public class VatRegistrationExternalService : IVatRegistrationExternalService
    {
        private readonly IVatRegistrationApiClient _vatRegistrationApiClient;

        public VatRegistrationExternalService(IVatRegistrationApiClient vatRegistrationApiClient)
        {
            _vatRegistrationApiClient = vatRegistrationApiClient;
        }

        public async Task RegisterVatAsync(string url, VatRegistrationExternalRequest request)
        {
            await _vatRegistrationApiClient.PostAsync(url, request);
        }
    }
}
