using System.Threading.Tasks;

namespace MicroService_Modelo.Services
{
    public class HealthService : IHealthService
    {
        public async Task<string> GetHealthData()
        {
            var data = "Service is up";
            await Task.Delay(10);
            return data;
        }
    }
}
