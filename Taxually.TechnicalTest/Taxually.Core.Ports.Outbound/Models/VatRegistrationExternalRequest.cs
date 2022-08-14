namespace Taxually.Core.Ports.Outbound.Models
{
    public class VatRegistrationExternalRequest
    {
        public string CompanyName { get; set; }
        public string CompanyId { get; set; }
        public string Country { get; set; }
    }
}
