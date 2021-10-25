using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdTicketApprovalStage
    {
        public HdTicketApprovalStage()
        {
            HdTicketApproval = new HashSet<HdTicketApproval>();
        }

        public long Id { get; set; }
        public byte Stage { get; set; }
        public long HdTicketApprovalParentId { get; set; }
        public long HdTicketId { get; set; }
        public string ApprovalType { get; set; }
        public DateTimeOffset? ApprovalDueDate { get; set; }
        public DateTimeOffset? ApprovalNotified { get; set; }
        public DateTimeOffset? ApprovalDate { get; set; }

        public virtual HdTicketApprovalParent HdTicketApprovalParent { get; set; }
        public virtual ICollection<HdTicketApproval> HdTicketApproval { get; set; }
    }
}