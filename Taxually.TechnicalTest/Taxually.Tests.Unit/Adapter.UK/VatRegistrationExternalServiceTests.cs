using FluentAssertions;
using NSubstitute;
using Taxually.Adapter.UK;
using Taxually.Adapter.UK.Interfaces;
using Taxually.Core.Ports.Outbound.Models;

namespace Taxually.Tests.Unit.Adapter.UK
{
    public class VatRegistrationExternalServiceTests
    {
        private IVatRegistrationApiClient _vatRegistrationApiClient;

        private VatRegistrationExternalService _vatRegistrationExternalService;

        [SetUp]
        public void Init()
        {
            _vatRegistrationApiClient = Substitute.For<IVatRegistrationApiClient>();
            _vatRegistrationExternalService = new VatRegistrationExternalService(_vatRegistrationApiClient);
        }

        [Test]
        public async Task RegisterVatAsync_WhenCalled_ShouldNotThrowException()
        {
            var act = () => _vatRegistrationExternalService.RegisterVatAsync("https://api.uktax.gov.uk", new VatRegistrationExternalRequest());

            await act.Should().NotThrowAsync();
        }
    }
}
