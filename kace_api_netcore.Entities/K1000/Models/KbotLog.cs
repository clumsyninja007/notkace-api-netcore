using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KbotLog
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public long KbotId { get; set; }
        public string KbotVersion { get; set; }
        public int? Status { get; set; }
        public long? StatusDetailId { get; set; }
        public long? DebugDetailId { get; set; }
        public long? OutputDetailId { get; set; }
        public long? ActivityDetailId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public long Serial { get; set; }
    }
}