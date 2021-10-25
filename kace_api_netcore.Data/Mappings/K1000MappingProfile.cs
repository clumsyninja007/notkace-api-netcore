using AutoMapper;
using kace_api_netcore.Data.K1000.Dtos;
using kace_api_netcore.Entities.K1000.Models;

namespace kace_api_netcore.Data.Mappings
{
    public class K1000MappingProfile : Profile
    {
        public K1000MappingProfile()
        {
            CreateMap<Asset, AssetDto>();
            CreateMap<User, UserDto>();
        }
    }
}
