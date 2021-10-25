using kace_api_netcore.Data.K2000.Dtos;
using System.Threading.Tasks;

namespace kace_api_netcore.Data.K2000.Interfaces
{
    public interface IDeploymentsService
    {
        Task<DeploymentDto> GetDeploymentByMacAddress(string macAddr);
    }
}
