using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamMeterTitledApplication
    {
        public string TitledApplicationId { get; set; }
        public byte IsMobile { get; set; }
        public byte Enabled { get; set; }
        public DateTimeOffset MeterActivated { get; set; }
    }
}