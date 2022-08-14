using Taxually.Adapter.UK.Interfaces;

namespace Taxually.Adapter.UK
{
    public class VatRegistrationApiClient : IVatRegistrationApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public const string Name = "VatRegistrationClient";

        public VatRegistrationApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public Task PostAsync<TRequest>(string url, TRequest request)
        {
            using (var client = _httpClientFactory.CreateClient(Name))
            {
                // Actual HTTP call removed for purposes of this exercise
                return Task.CompletedTask;
            }
        }
    }
}
