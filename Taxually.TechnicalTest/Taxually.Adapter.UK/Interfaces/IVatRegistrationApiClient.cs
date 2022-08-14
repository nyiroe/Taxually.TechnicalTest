namespace Taxually.Adapter.UK.Interfaces
{
    public interface IVatRegistrationApiClient
    {
        Task PostAsync<TRequest>(string url, TRequest request);
    }
}
