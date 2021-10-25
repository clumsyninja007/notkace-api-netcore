using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Kworkflow
    {
        public Kworkflow()
        {
            KworkflowApprover = new HashSet<KworkflowApprover>();
            KworkflowExecution = new HashSet<KworkflowExecution>();
        }

        public long Id { get; set; }
        public string CallbackClass { get; set; }
        public int WorkflowId { get; set; }
        public long? TimeoutMinutes { get; set; }
        public long? NotificationResendMinutes { get; set; }
        public byte UseBusinessHours { get; set; }

        public virtual Workflow Workflow { get; set; }
        public virtual ICollection<KworkflowApprover> KworkflowApprover { get; set; }
        public virtual ICollection<KworkflowExecution> KworkflowExecution { get; set; }
    }
}