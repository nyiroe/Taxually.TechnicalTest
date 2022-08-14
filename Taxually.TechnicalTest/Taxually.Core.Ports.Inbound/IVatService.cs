using Taxually.Core.Ports.Inbound.Models;

namespace Taxually.Core.Ports.Inbound
{
    public interface IVatService
    {
        Task RegisterVatAsync(VatRegistrationRequest request);
    }
}
