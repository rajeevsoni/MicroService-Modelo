using MicroService_Modelo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MicroService_Modelo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public async Task<IActionResult> GetServiceHealth()
        {
            _logger.LogInformation("Executing Health Endpoint");
            var response = await _dummyService.GetHealthData();
            return new OkObjectResult(response);
        }

        [HttpGet("Internet")]
        public async Task<IActionResult> GetInternetConnectivityHealth()
        {
            _logger.LogInformation("Executing Internet Health Endpoint");
            var response = await _dummyService.GetHealthData();
            return new OkObjectResult(response);
        }
    }
}
