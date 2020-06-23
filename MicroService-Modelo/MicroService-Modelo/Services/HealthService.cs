using MicroService_Modelo.CrossCuttings;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroService_Modelo.Services
{
    public class HealthService : IHealthService
    {
        private readonly ILogger<HealthService> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HealthService(ILogger<HealthService> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> GetHealthCheckData()
        {
            _logger.LogInformation("Inside Health Service for checking Service Health");
            var data = "Service is up";
            await Task.Delay(10);
            return data;
        }

        public async Task<string> GetInternetHealthCheckData()
        {
            _logger.LogInformation("Inside Health Service for checking Service Health");

            using (var httpClient = _httpClientFactory.CreateClient(HttpClientName.GoogleAPI))
            {
                var response = await httpClient.GetAsync("");
                
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return "Service is connected to internet.";
                }

                return "Service is not connected to internet.";
            }
        }
    }
}
