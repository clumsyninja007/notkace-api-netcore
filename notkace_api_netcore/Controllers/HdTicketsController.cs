using System.Collections.Generic;
using System.Data;
using System.Dynamic;
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
    public class HdTicketsController : ControllerBase
    {
        private readonly IDbConnection _connection;

        public HdTicketsController(IConfiguration configuration)
        {
            _connection = new MySqlConnection(configuration.GetConnectionString("KaceDb"));
        }

        // GET: api/HdTickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HdTicket>>> GetHdTicket()
        {
            const string sql = @"SELECT *
                                FROM HD_TICKET";

            return Ok(await _connection.QueryAsync<HdTicket>(sql));
        }

        // GET: api/HdTickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HdTicket>> GetHdTicket(long id)
        {
            const string sql = @"SELECT *
                                FROM HD_TICKET
                                WHERE ID = @id";

            var hdTicket = await _connection.QueryFirstOrDefaultAsync<HdTicket>(sql, new {id});

            if (hdTicket == null) return NotFound();

            return hdTicket;
        }

        // GET: api/HdTickets/Open
        [HttpGet("Open")]
        public async Task<ActionResult<IEnumerable<TicketAppDto>>> GetOpenTickets(
            [FromQuery] string assignee,
            string software,
            string referredTo,
            string department,
            string location)
        {
            var sql = @"SELECT
                            h.id AS Ticket
                            ,h.Title
                            ,p.NAME AS Priority
                            ,u.FULL_NAME AS Owner
                            ,s.FULL_NAME AS Submitter
                            ,a.name AS Asset
                            ,d.name AS Device
                            ,hd.NAME AS Status
                            ,h.CUSTOM_FIELD_VALUE5 AS ReferredTo
                            ,u.user_name AS UserName
                            ,CASE p.NAME
                            WHEN 'EMERGENCY' THEN 1
                            WHEN 'CRITICAL' THEN 2
                            WHEN 'HIGH' THEN 3
                            WHEN 'MEDIUM' THEN 4
                            ELSE 5
                            END AS PriOrd
                            ,CASE hd.NAME
                            WHEN 'NEW' THEN 1
                            WHEN 'Re-Assigned' THEN 2
                            WHEN 'OPENED' THEN 3
                            WHEN 'In Progress' THEN 4
                            WHEN 'Waiting on Customer' THEN 5
                            WHEN 'Waiting on Third Party' THEN 6
                            WHEN 'Need More Info' THEN 7
                            ELSE 8
                            END AS StatOrd
                            ,h.CUSTOM_FIELD_VALUE1 AS Dept
                            ,h.CUSTOM_FIELD_VALUE2 AS Location
                            FROM HD_TICKET AS h
                            INNER JOIN USER AS u
                            ON u.ID = h.OWNER_ID
                            INNER JOIN USER AS s
                            ON s.ID = h.SUBMITTER_ID
                            LEFT JOIN ASSET AS a
                            ON a.id = h.ASSET_ID
                            LEFT JOIN ASSET AS d
                            ON d.MAPPED_ID = h.MACHINE_ID
                            AND d.ASSET_TYPE_ID = 5
                            AND h.MACHINE_ID <> 0
                            INNER JOIN HD_STATUS AS hd
                            ON hd.id = h.HD_STATUS_ID
                            INNER JOIN HD_PRIORITY AS p
                            ON p.id = h.HD_PRIORITY_ID
                            WHERE hd.name <> 'CLOSED'";

            dynamic paramList = new ExpandoObject();

            if (assignee != null)
            {
                sql += " AND u.USER_NAME = @UserName";
                paramList.UserName = assignee;
            }

            if (software != null)
            {
                sql += " AND a.NAME = @Software";
                paramList.Software = software;
            }

            if (referredTo != null)
            {
                sql += " AND h.CUSTOM_FIELD_VALUE5 = @ReferredTo";
                paramList.ReferredTo = referredTo;
            }

            if (department != null)
            {
                sql += " AND h.CUSTOM_FIELD_VALUE1 = @Dept";
                paramList.Dept = department;
            }

            if (location != null)
            {
                sql += " AND h.CUSTOM_FIELD_VALUE2 = @Location";
                paramList.Location = location;
            }

            sql += " ORDER BY u.FULL_NAME, PriOrd, StatOrd";

            return Ok(await _connection.QueryAsync<TicketAppDto>(sql, (object) paramList));
        }

        // GET: api/HdTickets/Open/5
        [HttpGet("Open/{id}")]
        public async Task<ActionResult<TicketInfoDto>> GetTicketInfo([FromRoute] long id)
        {
            const string sql = @"SELECT h.ID AS Ticket
                                          ,LTRIM(RTRIM(h.SUMMARY)) AS Summary
                                          ,c.COMMENT AS Comment
                                          ,c.TIMESTAMP AS Timestamp
                                          ,cu.FULL_NAME AS Commenter
                                        FROM HD_TICKET AS h
                                        LEFT JOIN HD_TICKET_CHANGE AS c
                                          ON c.HD_TICKET_ID = h.ID
                                          AND c.ID = (SELECT MAX(cc.ID)
                                                      FROM HD_TICKET_CHANGE cc
                                                      WHERE cc.HD_TICKET_ID = c.HD_TICKET_ID
                                                        AND cc.COMMENT <> ''
                                                        AND cc.COMMENT IS NOT NULL)
                                        LEFT JOIN USER AS cu
                                          ON cu.ID = c.USER_ID
                                        WHERE h.ID = @id";

            return Ok(await _connection.QueryFirstOrDefaultAsync<TicketInfoDto>(sql, new {id}));
        }
    }
}