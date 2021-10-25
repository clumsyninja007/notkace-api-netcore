using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamMeterData
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public string TitledApplicationId { get; set; }
        public byte IsMobile { get; set; }
        public string Version { get; set; }
        public string ProcessId { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public string UserData { get; set; }
        public short Launches { get; set; }
        public int SecondsUsed { get; set; }
        public byte LatestEntry { get; set; }
        public DateTime ServerDate { get; set; }
    }
}