using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using notkace_api_netcore.Models;

namespace notkace_api_netcore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDbConnection _connection;

        public UsersController(IConfiguration configuration)
        {
            _connection = new MySqlConnection(configuration.GetConnectionString("KaceDb"));
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            const string sql = @"SELECT *
                                FROM USER";

            return Ok(await _connection.QueryAsync<User>(sql));
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(long id)
        {
            const string sql = @"SELECT *
                                FROM USER
                                WHERE ID = @id";

            var user = await _connection.QueryFirstOrDefaultAsync<User>(sql, new {id});

            if (user == null) return NotFound();

            return user;
        }

        [HttpGet("owners")]
        public async Task<ActionResult<IEnumerable<User>>> GetOwners()
        {
            const string sql = @"SELECT *
                                FROM USER
                                WHERE ROLE_ID = 5
                                ORDER BY FULL_NAME";

            return Ok(await _connection.QueryAsync<User>(sql));
        }
    }
}