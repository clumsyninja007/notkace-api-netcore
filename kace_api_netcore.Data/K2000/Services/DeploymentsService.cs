using kace_api_netcore.Data.K2000.Dtos;
using kace_api_netcore.Data.K2000.Interfaces;
using kace_api_netcore.Entities.K2000;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace kace_api_netcore.Data.K2000.Services
{
    public class DeploymentsService : IDeploymentsService
    {
        private readonly KBDBContext _context;

        public DeploymentsService(KBDBContext context)
        {
            _context = context;
        }

        public Task<DeploymentDto> GetDeploymentByMacAddress(string macAddr)
        {
            return _context.ImDeploymentLog
                .AsNoTracking()
                .Select(l => new DeploymentDto
                {
                    MAC = l.ImNode.Mac,
                    Name = l.ImDeployment.Name,
                    Deleted = l.ImDeployment.Deleted,
                    LogId = l.LogId,
                    DeployStarted = l.DeployStarted,
                    DeployCompleted = l.DeployCompleted,
                    Status = l.Status
                })
                .Where(l => l.MAC == macAddr)
                .OrderByDescending(l => l.DeployStarted)
                .FirstOrDefaultAsync();
        }
    }
}
