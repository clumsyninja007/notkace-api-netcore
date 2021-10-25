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
    public class UsersService : IUsersService
    {
        private readonly ORG1Context _context;
        private readonly IMapper _mapper;

        public UsersService(ORG1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<UserDto>> GetUsers()
        {
            return _context.User
                .AsNoTracking()
                .OrderBy(u => u.FullName)
                .Select(u => _mapper.Map<UserDto>(u))
                .ToListAsync();
        }

        public Task<UserDto> GetUserById(long id)
        {
            return _context.User
                .AsNoTracking()
                .Where(u => u.Id == id)
                .Select(u => _mapper.Map<UserDto>(u))
                .FirstOrDefaultAsync();
        }

        public Task<List<UserDto>> GetTicketOwners()
        {
            return _context.User
                .AsNoTracking()
                .Where(u => u.RoleId == 5)
                .OrderBy(u => u.FullName)
                .Select(u => _mapper.Map<UserDto>(u))
                .ToListAsync();
        }
    }
}
