namespace kace_api_netcore.Entities.K1000.Models
{
    public class KworkflowExecutionApproverStatus
    {
        public long Id { get; set; }
        public long KworkflowExecutionId { get; set; }
        public long UserId { get; set; }
        public string Approval { get; set; }
        public int Stage { get; set; }

        public virtual KworkflowExecution KworkflowExecution { get; set; }
    }
}