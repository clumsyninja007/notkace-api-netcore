using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserDownloadApprovalHistory
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? PortalId { get; set; }
        public long? HdTicketId { get; set; }
        public short? IsComplete { get; set; }
        public string Note { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}