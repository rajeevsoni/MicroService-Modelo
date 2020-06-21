using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MicroService_Modelo.Services
{
    public class HealthService : IHealthService
    {
        private readonly ILogger<HealthService> _logger;

        public HealthService(ILogger<HealthService> logger)
        {
            _logger = logger;
        }
        public async Task<string> GetHealthData()
        {
            _logger.LogInformation("Inside Health Service for checking Service Health");
            var data = "Service is up";
            await Task.Delay(10);
            return data;
        }
    }
}
