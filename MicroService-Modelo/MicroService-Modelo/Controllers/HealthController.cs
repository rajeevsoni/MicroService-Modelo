using MicroService_Modelo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MicroService_Modelo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private IHealthService _dummyService;

        public HealthController(IHealthService dummyService)
        {
            _dummyService = dummyService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _dummyService.GetHealthData();
            return new OkObjectResult(response);
        }
    }
}
