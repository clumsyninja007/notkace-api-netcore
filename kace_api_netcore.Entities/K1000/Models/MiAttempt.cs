namespace kace_api_netcore.Entities.K1000.Models
{
    public class MiAttempt
    {
        public long MiId { get; set; }
        public long MachineId { get; set; }
        public long AttemptCount { get; set; }
        public byte RunNow { get; set; }
    }
}