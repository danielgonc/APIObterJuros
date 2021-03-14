using Microsoft.AspNetCore.Mvc;

namespace APIObterJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        [HttpGet, Route("taxaJuros")]
        public IActionResult GetTaxaJuros()
        {
            return Ok(new { taxa = 0.01 });
        }
    }
}
