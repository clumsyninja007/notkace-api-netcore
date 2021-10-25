using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineDailyUptime
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public DateTime Day { get; set; }
        public decimal Hours { get; set; }
    }
}