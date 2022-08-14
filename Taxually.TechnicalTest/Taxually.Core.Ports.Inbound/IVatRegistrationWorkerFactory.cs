namespace Taxually.Core.Ports.Inbound
{
    public interface IVatRegistrationWorkerFactory
    {
        IVatRegistrationWorker GetVatRegistrationWorker(string country);
    }
}
