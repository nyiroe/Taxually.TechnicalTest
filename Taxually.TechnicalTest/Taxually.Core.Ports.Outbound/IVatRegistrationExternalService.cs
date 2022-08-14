using Taxually.Core.Ports.Outbound.Models;

namespace Taxually.Core.Ports.Outbound
{
    public interface IVatRegistrationExternalService
    {
        Task RegisterVatAsync(string url, VatRegistrationExternalRequest request);
    }
}
