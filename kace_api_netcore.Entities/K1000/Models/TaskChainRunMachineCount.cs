namespace kace_api_netcore.Entities.K1000.Models
{
    public class TaskChainRunMachineCount
    {
        public long Id { get; set; }
        public long TaskChainRunId { get; set; }
        public long StepOrdinal { get; set; }
        public long Queued { get; set; }
        public long Running { get; set; }
        public long Success { get; set; }
        public long Failure { get; set; }
    }
}