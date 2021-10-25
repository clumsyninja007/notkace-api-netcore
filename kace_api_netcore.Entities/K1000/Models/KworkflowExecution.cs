using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KworkflowExecution
    {
        public KworkflowExecution()
        {
            KworkflowExecutionApproverStatus = new HashSet<KworkflowExecutionApproverStatus>();
        }

        public long Id { get; set; }
        public string CallbackClass { get; set; }
        public int? ExecutionId { get; set; }
        public long? KworkflowId { get; set; }
        public long? TimeoutMinutes { get; set; }
        public long? NotificationResendMinutes { get; set; }
        public byte UseBusinessHours { get; set; }
        public int CurrentStage { get; set; }
        public byte? Started { get; set; }
        public byte? Ended { get; set; }

        public virtual Kworkflow Kworkflow { get; set; }
        public virtual ICollection<KworkflowExecutionApproverStatus> KworkflowExecutionApproverStatus { get; set; }
    }
}