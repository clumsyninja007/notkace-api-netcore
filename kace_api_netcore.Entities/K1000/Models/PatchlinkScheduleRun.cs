using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkScheduleRun
    {
        public long Id { get; set; }
        public long PatchlinkScheduleId { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
        public DateTimeOffset RunTime { get; set; }
    }
}