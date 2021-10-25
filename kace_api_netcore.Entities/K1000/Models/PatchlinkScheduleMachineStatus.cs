using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkScheduleMachineStatus
    {
        public long PatchlinkScheduleId { get; set; }
        public long MachineId { get; set; }
        public long? Patched { get; set; }
        public long? Notpatched { get; set; }
        public long? DetectFailures { get; set; }
        public long? DeployRollbackFailures { get; set; }
        public DateTime? LastRun { get; set; }
    }
}