namespace kace_api_netcore.Entities.K1000.Models
{
    public class KworkflowApprover
    {
        public long Id { get; set; }
        public long KworkflowId { get; set; }
        public string Approver { get; set; }
        public int Stage { get; set; }
        public int StageType { get; set; }

        public virtual Kworkflow Kworkflow { get; set; }
    }
}