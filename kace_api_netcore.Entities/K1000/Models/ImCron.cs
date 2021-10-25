using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ImCron
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public byte Enabled { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Minutes { get; set; }
        public string Hours { get; set; }
        public string DaysOfMonth { get; set; }
        public string Months { get; set; }
        public string DaysOfWeek { get; set; }
        public string Command { get; set; }
        public string Type { get; set; }
        public byte IsAgentTimeZone { get; set; }
        public string TzForOffset { get; set; }
    }
}