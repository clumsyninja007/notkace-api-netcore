using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KbotLogLatest
    {
        public long MachineId { get; set; }
        public long KbotId { get; set; }
        public long KbotLogId { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public long Serial { get; set; }
    }
}