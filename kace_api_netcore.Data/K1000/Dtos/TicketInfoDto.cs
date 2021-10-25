using System;

namespace kace_api_netcore.Data.K1000.Dtos
{
    public class TicketInfoDto
    {
        public long Ticket { get; init; }
        public string Summary { get; set; }
        public string Comment { get; set; }
        public DateTime Timestamp { get; init; }
        public string Commenter { get; init; }
        public byte OwnersOnly { get; init; }
    }
}