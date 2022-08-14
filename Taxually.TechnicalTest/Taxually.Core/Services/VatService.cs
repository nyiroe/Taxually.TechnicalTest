using Taxually.Core.Ports.Inbound;
using Taxually.Core.Ports.Inbound.Models;

namespace Taxually.Core.Services
{
    public class VatService : IVatService
    {
        private readonly IVatRegistrationWorkerFactory _vatRegistrationWorkerFactory;

        public VatService(IVatRegistrationWorkerFactory vatRegistrationWorkerFactory)
        {
            _vatRegistrationWorkerFactory = vatRegistrationWorkerFactory;
        }

        public async Task RegisterVatAsync(VatRegistrationRequest request)
        {
            var vatRegistrationWorker = _vatRegistrationWorkerFactory.GetVatRegistrationWorker(request.Country);

            await vatRegistrationWorker.RegisterVatAsync(request);
        }
    }
}
