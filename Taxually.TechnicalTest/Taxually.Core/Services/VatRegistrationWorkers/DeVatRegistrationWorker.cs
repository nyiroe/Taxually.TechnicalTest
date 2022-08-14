using Taxually.Core.Ports.Inbound;
using Taxually.Core.Ports.Inbound.Models;

namespace Taxually.Core.Services.VatRegistrationWorkers
{
    public class DeVatRegistrationWorker : IVatRegistrationWorker
    {
        public Task RegisterVatAsync(VatRegistrationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
