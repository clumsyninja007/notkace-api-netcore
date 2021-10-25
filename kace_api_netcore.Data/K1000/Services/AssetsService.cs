using AutoMapper;
using kace_api_netcore.Data.K1000.Dtos;
using kace_api_netcore.Data.K1000.Interfaces;
using kace_api_netcore.Entities.K1000;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kace_api_netcore.Data.K1000.Services
{
    public class AssetsService : IAssetsService
    {
        private readonly ORG1Context _context;
        private readonly IMapper _mapper;

        public AssetsService(ORG1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<AssetDto>> GetAssets()
        {
            return _context.Asset
                .AsNoTracking()
                .OrderBy(a => a.Name)
                .Select(a => _mapper.Map<AssetDto>(a))
                .ToListAsync();
        }

        public Task<AssetDto> GetAssetById(long id)
        {
            return _context.Asset
                .AsNoTracking()
                .Where(a => a.Id == id)
                .Select(a => _mapper.Map<AssetDto>(a))
                .FirstOrDefaultAsync();
        }

        public Task<List<AssetDto>> GetAssetsByTypeId(long id)
        {
            return _context.Asset
                .AsNoTracking()
                .Where(a => a.AssetTypeId == id)
                .OrderBy(a => a.Name)
                .Select(a => _mapper.Map<AssetDto>(a))
                .ToListAsync();
        }
    }
}
