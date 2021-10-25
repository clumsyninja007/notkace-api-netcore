using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScapResult
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public long ScapProfileId { get; set; }
        public DateTime EndTime { get; set; }
        public string ResultValue { get; set; }
    }
}