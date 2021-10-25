using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class TaskChainRun
    {
        public long Id { get; set; }
        public long TaskChainId { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public long Total { get; set; }
        public long Queued { get; set; }
        public long Running { get; set; }
        public long Success { get; set; }
        public long Failure { get; set; }
    }
}