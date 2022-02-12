using InfoNinjasApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace InfoNinjasApi.Features.NinjaFeatures
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class NinjaController : ControllerBase
    {
        private readonly ILogger<NinjaController> _logger;
        private readonly INinjaService _ninjaService;

        public NinjaController(ILogger<NinjaController> logger, INinjaService ninjaService)
        {
            _logger = logger;
            _ninjaService = ninjaService;
        }

        /// <summary>
        /// Get a list of all Ninjas
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetNinjas")]
        public async Task<IActionResult> GetAllNinjas()
        {
            var allNinjas = await _ninjaService.GetAllNinjas();

            return Ok(allNinjas);
        }
    }
}
