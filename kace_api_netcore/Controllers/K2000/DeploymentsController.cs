using kace_api_netcore.Data.K2000.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace kace_api_netcore.Controllers.K2000
{
    [AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class DeploymentsController : ControllerBase
    {
        private readonly IDeploymentsService _deploymentsService;

        public DeploymentsController(IDeploymentsService deploymentsService)
        {
            _deploymentsService = deploymentsService;
        }

        /// <summary>
        /// Pulls deployment information based on the given Mac Address
        /// </summary>
        /// <param name="macAddr"></param>
        /// <returns>A string containing deployment name and date</returns>
        [HttpGet(
            "{macAddr:regex(^[[a-fA-F0-9]]{{2}}[[:-]][[a-fA-F0-9]]{{2}}[[:-]][[a-fA-F0-9]]{{2}}[[:-]][[a-fA-F0-9]]{{2}}[[:-]][[a-fA-F0-9]]{{2}}[[:-]][[a-fA-F0-9]]{{2}}$)}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<string>> GetDeploymentsForMac(string macAddr)
        {
            macAddr = macAddr.Replace("-", ":");

            var deployment = await _deploymentsService.GetDeploymentByMacAddress(macAddr);

            if (deployment == null)
            {
                return NotFound();
            }

            return $"Deployment Name: {deployment.Name}\nDeployed On: {deployment.DeployStarted}";
        }
    }
}