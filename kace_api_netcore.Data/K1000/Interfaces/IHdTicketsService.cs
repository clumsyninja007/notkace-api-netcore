using kace_api_netcore.Data.K1000.Dtos;
using kace_api_netcore.Data.Models;
using System.Threading;
using System.Threading.Tasks;

namespace kace_api_netcore.Data.K1000.Interfaces
{
    public interface IHdTicketsService
    {
        Task<PagedModel<HdTicketsDto>> GetPaginatedHdTicketList(PaginatedHdTicketListParams queryParams, string dept,
            CancellationToken cancellationToken);
        Task<HdTicketsDto> GetHdTicketById(long id);
        Task<TicketInfoDto> GetLatestHdTicketCommentByTicketId(long id, string dept);
    }
}
