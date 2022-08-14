using Microsoft.Extensions.DependencyInjection;
using Taxually.Adapter.UK.Interfaces;
using Taxually.Core.Ports.Outbound;

namespace Taxually.Adapter.UK
{
    public static class ServiceBuilderExternsions
    {
        public static IServiceCollection AddUkVatHttpClient(this IServiceCollection services)
        {
            services
                .AddHttpClient(VatRegistrationApiClient.Name);

            return services
                .AddScoped<IVatRegistrationApiClient, VatRegistrationApiClient>()
                .AddScoped<IVatRegistrationExternalService, VatRegistrationExternalService>();
        }
    }
}
