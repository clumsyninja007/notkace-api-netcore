using kace_api_netcore.Data.K1000.Dtos;
using kace_api_netcore.Data.K1000.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using kace_api_netcore.Auth.Interfaces;

namespace kace_api_netcore.Controllers.K1000
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        private readonly IAuthenticationService _authenticationService;

        public UsersController(IUsersService usersService, IAuthenticationService authenticationService)
        {
            _usersService = usersService;
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// Pulls all Kace users
        /// </summary>
        /// <returns>A list of Users</returns>
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<List<UserDto>>> GetUsers()
        {
            return await _usersService.GetUsers();
        }

        /// <summary>
        /// Pulls a single Kace user by ID
        /// </summary>
        /// <returns>A single User</returns>
        [HttpGet("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<UserDto>> GetUser(long id)
        {
            return await _usersService.GetUserById(id);
        }

        /// <summary>
        /// Pulls all Kace users with the TicketOwner role
        /// </summary>
        /// <returns>A list of Users</returns>
        [HttpGet("owners")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<List<UserDto>>> GetOwners()
        {
            return await _usersService.GetTicketOwners();
        }

        /// <summary>
        /// Pulls the AD department of the current user
        /// </summary>
        /// <returns>A department name as a string</returns>
        [HttpGet("current-user/department")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public string GetDepartment()
        {
            return _authenticationService.GetDepartmentByUsername(User.Identity?.Name);
        }
    }
}