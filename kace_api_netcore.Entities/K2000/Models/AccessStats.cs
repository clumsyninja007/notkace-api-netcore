using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class AccessStats
    {
        public string Filename { get; set; }
        public int RequestCount { get; set; }
        public DateTimeOffset FirstAccess { get; set; }
        public DateTime LastAccess { get; set; }
    }
}