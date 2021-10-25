using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamMachineTerminatedApps
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public string TitledApplicationId { get; set; }
        public byte IsMobile { get; set; }
        public DateTimeOffset End { get; set; }
        public string UserData { get; set; }
    }
}