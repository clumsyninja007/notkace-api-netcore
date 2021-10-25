using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdTicketApprovalParent
    {
        public HdTicketApprovalParent()
        {
            HdTicketApprovalStage = new HashSet<HdTicketApprovalStage>();
        }

        public long Id { get; set; }
        public long HdTicketId { get; set; }
        public long ApprovalId { get; set; }
        public long KworkflowExecutionId { get; set; }
        public long TimeoutMinutes { get; set; }
        public long NotificationRecurrenceMinutes { get; set; }
        public long UseBusinessHours { get; set; }

        public virtual HdTicket HdTicket { get; set; }
        public virtual ICollection<HdTicketApprovalStage> HdTicketApprovalStage { get; set; }
    }
}