using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DellMachinePkgUpdateStatus
    {
        public long MachineId { get; set; }
        public long CatalogId { get; set; }
        public string PackageDid { get; set; }
        public int UpdateCount { get; set; }
        public DateTime UpdateStatusDt { get; set; }
        public int? MaxUpdateAttempt { get; set; }
        public long DellScheduleId { get; set; }
    }
}