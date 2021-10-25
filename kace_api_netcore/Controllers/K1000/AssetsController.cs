using kace_api_netcore.Data.K1000.Dtos;
using kace_api_netcore.Data.K1000.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace kace_api_netcore.Controllers.K1000
{
    [Route("[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetsService _assetsService;

        public AssetsController(IAssetsService assetsService)
        {
            _assetsService = assetsService;
        }

        /// <summary>
        /// Pulls all assets
        /// </summary>
        /// <returns>A list of Assets</returns>
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<List<AssetDto>>> GetAssets()
        {
            return await _assetsService.GetAssets();
        }

        /// <summary>
        /// Pulls an asset by asset ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single Asset</returns>
        [HttpGet("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<AssetDto>> GetAsset(long id)
        {
            return await _assetsService.GetAssetById(id);
        }

        /// <summary>
        /// Pulls all assets of a given Asset Type
        /// </summary>
        /// <param name="id">An Asset Type ID</param>
        /// <returns>A list of Assets</returns>
        [HttpGet("Type/{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<List<AssetDto>>> GetAssetsByType(long id)
        {
            return await _assetsService.GetAssetsByTypeId(id);
        }
    }
}