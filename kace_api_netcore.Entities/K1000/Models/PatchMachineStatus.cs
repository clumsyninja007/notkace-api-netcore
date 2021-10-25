using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchMachineStatus
    {
        public long MachineId { get; set; }
        public DateTime? StatusDt { get; set; }
        public string PatchId { get; set; }
        public string PatchProductId { get; set; }
        public string PatchDetect { get; set; }
        public int ProductInstalled { get; set; }
        public int PatchInstalled { get; set; }
        public int PatchApplicable { get; set; }
        public long DetectErrorCode { get; set; }
        public string DetectRdesc { get; set; }
        public long ScheduleId { get; set; }
    }
}