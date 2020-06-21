using MicroService_Modelo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MicroService_Modelo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private IHealthService _dummyService;
        private ILogger<HealthController> _logger;

        public HealthController(IHealthService dummyService, ILogger<HealthController> logger)
        {
            _dummyService = dummyService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Executing Health Endpoint");
            var response = await _dummyService.GetHealthData();
            _logger.LogInformation("");
            return new OkObjectResult(response);
        }
    }
}
