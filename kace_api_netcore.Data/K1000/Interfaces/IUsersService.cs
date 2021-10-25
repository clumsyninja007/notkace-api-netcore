using kace_api_netcore.Data.K1000.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace kace_api_netcore.Data.K1000.Interfaces
{
    public interface IUsersService
    {
        Task<List<UserDto>> GetUsers();
        Task<UserDto> GetUserById(long id);
        Task<List<UserDto>> GetTicketOwners();
    }
}
