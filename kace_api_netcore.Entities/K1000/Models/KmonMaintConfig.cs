using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonMaintConfig
    {
        public long KmonMaintConfigId { get; set; }
        public long KmonConfigId { get; set; }
        public int MaintenanceFrequency { get; set; }
        public int? MaintenanceDay { get; set; }
        public int? MaintenanceMonth { get; set; }
        public TimeSpan MaintenanceStartTime { get; set; }
        public TimeSpan MaintenanceEndTime { get; set; }

        public virtual KmonConfig KmonConfig { get; set; }
    }
}