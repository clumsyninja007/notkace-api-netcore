using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImServerTaskQueue
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTime TimeLaunched { get; set; }
        public DateTime TimeCompleted { get; set; }
        public string Queue { get; set; }
        public string Description { get; set; }
        public string Command { get; set; }
        public int? ExitStatus { get; set; }
    }
}