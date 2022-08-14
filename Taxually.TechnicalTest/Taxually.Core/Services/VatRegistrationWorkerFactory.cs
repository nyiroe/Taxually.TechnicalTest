using Taxually.Core.Ports.Inbound;
using Taxually.Core.Services.VatRegistrationWorkers;

namespace Taxually.Core.Services
{
    public class VatRegistrationWorkerFactory : IVatRegistrationWorkerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public VatRegistrationWorkerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IVatRegistrationWorker GetVatRegistrationWorker(string country)
        {
            switch (country)
            {
                case "GB":
                    return (IVatRegistrationWorker)_serviceProvider.GetService(typeof(UkVatRegistrationWorker))!;
                case "FR":
                    return (IVatRegistrationWorker)_serviceProvider.GetService(typeof(FrVatRegistrationWorker))!;
                case "DE":
                    return (IVatRegistrationWorker)_serviceProvider.GetService(typeof(DeVatRegistrationWorker))!;
                default:
                    throw new Exception("Country not supported");
            }
        }
    }
}
