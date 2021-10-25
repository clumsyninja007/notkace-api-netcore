using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdTicketApproval
    {
        public long Id { get; set; }
        public long HdTicketId { get; set; }
        public long HdTicketApprovalStageId { get; set; }
        public long UserId { get; set; }
        public string Approval { get; set; }
        public string ApprovalNote { get; set; }
        public DateTimeOffset? ApprovalDate { get; set; }

        public virtual HdTicketApprovalStage HdTicketApprovalStage { get; set; }
    }
}