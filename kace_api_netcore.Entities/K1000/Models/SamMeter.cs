using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamMeter
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public DateTimeOffset LastUpload { get; set; }
        public string LastReport { get; set; }
    }
}