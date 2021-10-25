using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineDdpe
    {
        public long Id { get; set; }
        public string Mcid { get; set; }
        public string ServerHostname { get; set; }
        public string AgentVersion { get; set; }
        public string ProtectionStatus { get; set; }
        public DateTime? ProtectionStatusUpdated { get; set; }
    }
}