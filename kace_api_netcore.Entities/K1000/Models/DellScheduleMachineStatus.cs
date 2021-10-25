using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DellScheduleMachineStatus
    {
        public long DellScheduleId { get; set; }
        public long MachineId { get; set; }
        public DateTime? LastRun { get; set; }
    }
}