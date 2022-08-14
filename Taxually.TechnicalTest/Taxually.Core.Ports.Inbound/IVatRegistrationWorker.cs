using Taxually.Core.Ports.Inbound.Models;

namespace Taxually.Core.Ports.Inbound
{
    public interface IVatRegistrationWorker
    {
        Task RegisterVatAsync(VatRegistrationRequest request);
    }
}
