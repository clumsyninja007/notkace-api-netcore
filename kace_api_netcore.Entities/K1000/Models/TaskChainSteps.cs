namespace kace_api_netcore.Entities.K1000.Models
{
    public class TaskChainSteps
    {
        public long TaskChainId { get; set; }
        public long Ordinal { get; set; }
        public string TaskType { get; set; }
        public long TaskTypeId { get; set; }
        public byte AbortOnFailure { get; set; }
    }
}