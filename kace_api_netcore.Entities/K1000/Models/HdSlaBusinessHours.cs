using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdSlaBusinessHours
    {
        public long Id { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public byte? IsAllDay { get; set; }
        public byte? IsClosed { get; set; }
    }
}