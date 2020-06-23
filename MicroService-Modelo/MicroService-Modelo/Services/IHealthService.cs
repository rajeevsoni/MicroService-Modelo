using System.Threading.Tasks;

namespace MicroService_Modelo.Services
{
    public interface IHealthService
    {
        Task<string> GetHealthCheckData();
        Task<string> GetInternetHealthCheckData();
    }
}
