using Microsoft.AspNetCore.Mvc;
using Taxually.Core.Ports.Inbound;
using Taxually.Core.Ports.Inbound.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taxually.TechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VatRegistrationController : ControllerBase
    {
        private readonly IVatService _vatService;

        public VatRegistrationController(IVatService vatService)
        {
            _vatService = vatService;
        }

        /// <summary>
        /// Registers a company for a VAT number in a given country
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] VatRegistrationRequest request)
        {
            await _vatService.RegisterVatAsync(request);

            return Ok();
        }
    }
}
