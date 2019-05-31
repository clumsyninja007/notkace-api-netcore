using System;

namespace notkace_api_netcore.Models
{
    public class TicketInfoDto
    {
        public long Ticket { get; set; }
        public string Summary { get; set; }
        public string Comment { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Commenter { get; set; }
    }
}