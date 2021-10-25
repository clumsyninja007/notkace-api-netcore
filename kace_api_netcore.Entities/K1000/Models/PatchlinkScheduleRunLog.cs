using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkScheduleRunLog
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public long PatchlinkScheduleId { get; set; }
        public long PatchlinkScheduleRunId { get; set; }
        public string Status { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
    }
}