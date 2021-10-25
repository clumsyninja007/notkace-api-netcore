using kace_api_netcore.Data.K1000.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace kace_api_netcore.Data.K1000.Interfaces
{
    public interface IAssetsService
    {
        Task<List<AssetDto>> GetAssets();
        Task<AssetDto> GetAssetById(long id);
        Task<List<AssetDto>> GetAssetsByTypeId(long id);
    }
}
