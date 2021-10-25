namespace kace_api_netcore.Entities.K1000.Models
{
    public class TaskChainRunMachine
    {
        public long TaskChainRunId { get; set; }
        public long MachineId { get; set; }
        public long? StepOrdinal { get; set; }
        public string Status { get; set; }
    }
}