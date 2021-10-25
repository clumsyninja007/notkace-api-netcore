using kace_api_netcore.Data.K1000.Dtos;
using kace_api_netcore.Data.K1000.Interfaces;
using kace_api_netcore.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using kace_api_netcore.Auth.Interfaces;

namespace kace_api_netcore.Controllers.K1000
{
    [Route("[controller]")]
    [ApiController]
    public class HdTicketsController : ControllerBase
    {
        private readonly IHdTicketsService _hdTicketsService;
        private readonly IAuthenticationService _authenticationService;

        public HdTicketsController(IHdTicketsService hdTicketsService, IAuthenticationService authenticationService)
        {
            _hdTicketsService = hdTicketsService;
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// Pulls all tickets that match the query parameters
        /// </summary>
        /// <param name="queryParams"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A list of Tickets</returns>
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<PagedModel<HdTicketsDto>>> GetHdTicketsAsync(
            [FromQuery] PaginatedHdTicketListParams queryParams, CancellationToken cancellationToken)
        {
            var dept = _authenticationService.GetDepartmentByUsername(User.Identity?.Name);

            return await _hdTicketsService.GetPaginatedHdTicketList(queryParams, dept, cancellationToken);
        }

        /// <summary>
        /// Pulls a ticket by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single Ticket</returns>
        [HttpGet("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<HdTicketsDto>> GetHdTicket(long id)
        {
            return await _hdTicketsService.GetHdTicketById(id);
        }

        /// <summary>
        /// Pulls the most recent ticket comment
        /// Filters out "Owners Only" comments for non-IT
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A single Ticket Comment</returns>
        [HttpGet("{id}/Info")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<TicketInfoDto>> GetHdTicketInfo(long id)
        {
            var dept = _authenticationService.GetDepartmentByUsername(User.Identity?.Name);

            return await _hdTicketsService.GetLatestHdTicketCommentByTicketId(id, dept);
        }
    }
}