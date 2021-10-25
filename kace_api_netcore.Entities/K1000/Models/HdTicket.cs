using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdTicket
    {
        public HdTicket()
        {
            HdTicketApprovalParent = new HashSet<HdTicketApprovalParent>();
            HdWork = new HashSet<HdWork>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public long HdPriorityId { get; set; }
        public long HdImpactId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long OwnerId { get; set; }
        public long SubmitterId { get; set; }
        public long HdStatusId { get; set; }
        public long HdQueueId { get; set; }
        public long HdCategoryId { get; set; }
        public string CcList { get; set; }
        public DateTimeOffset Escalated { get; set; }
        public string CustomFieldValue0 { get; set; }
        public string CustomFieldValue1 { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string CustomFieldValue3 { get; set; }
        public string CustomFieldValue4 { get; set; }
        public string CustomFieldValue5 { get; set; }
        public string CustomFieldValue6 { get; set; }
        public string CustomFieldValue7 { get; set; }
        public string CustomFieldValue8 { get; set; }
        public string CustomFieldValue9 { get; set; }
        public string CustomFieldValue10 { get; set; }
        public string CustomFieldValue11 { get; set; }
        public string CustomFieldValue12 { get; set; }
        public string CustomFieldValue13 { get; set; }
        public string CustomFieldValue14 { get; set; }
        public string CustomFieldValue15 { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public byte IsManualDueDate { get; set; }
        public DateTimeOffset SlaNotified { get; set; }
        public DateTimeOffset TimeOpened { get; set; }
        public DateTimeOffset TimeClosed { get; set; }
        public DateTimeOffset TimeStalled { get; set; }
        public long? MachineId { get; set; }
        public int? SatisfactionRating { get; set; }
        public string SatisfactionComment { get; set; }
        public string Resolution { get; set; }
        public long? AssetId { get; set; }
        public long ParentId { get; set; }
        public byte? IsParent { get; set; }
        public long ApproverId { get; set; }
        public string ApproveState { get; set; }
        public string Approval { get; set; }
        public string ApprovalNote { get; set; }
        public long? ServiceTicketId { get; set; }
        public long? HdServiceStatusId { get; set; }
        public byte? HdUseProcessStatus { get; set; }

        public virtual ICollection<HdTicketApprovalParent> HdTicketApprovalParent { get; set; }
        public virtual ICollection<HdWork> HdWork { get; set; }

        public virtual User Owner { get; set; }
        public virtual User Submitter { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual Asset Machine { get; set; }
        public virtual HdStatus Status { get; set; }
        public virtual HdPriority Priority { get; set; }
        public virtual ICollection<HdTicketChange> HdTicketChanges { get; set; }
    }
}