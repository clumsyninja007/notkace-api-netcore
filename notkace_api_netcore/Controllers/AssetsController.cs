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
    public class AssetsController : ControllerBase
    {
        private readonly IDbConnection _connection;

        public AssetsController(IConfiguration configuration)
        {
            _connection = new MySqlConnection(configuration.GetConnectionString("KaceDb"));
        }

        // GET: api/Assets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asset>>> GetAsset()
        {
            const string sql = @"SELECT *
                                FROM ASSET";

            return Ok(await _connection.QueryAsync<Asset>(sql));
        }

        // GET: api/Assets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asset>> GetAsset(long id)
        {
            const string sql = @"SELECT *
                                FROM ASSET
                                WHERE id = @id";

            var asset = await _connection.QueryFirstOrDefaultAsync<Asset>(sql, new {id});

            if (asset == null) return NotFound();

            return asset;
        }

        // PUT: api/Assets/Type/5
        [HttpGet("Type/{id}")]
        public async Task<ActionResult<IEnumerable<Asset>>> GetAssetsByType([FromRoute] long id)
        {
            const string sql = @"SELECT *
                                FROM ASSET
                                WHERE ASSET_TYPE_ID = @id
                                ORDER BY NAME";

            return Ok(await _connection.QueryAsync<Asset>(sql, new {id}));
        }
    }
}