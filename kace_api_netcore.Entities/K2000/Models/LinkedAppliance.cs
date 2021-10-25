using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class LinkedAppliance
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string HostName { get; set; }
        public byte SslEnabled { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
        public string PublicKeyFingerprint { get; set; }
        public string PublicKey { get; set; }
        public string Status { get; set; }
        public string DefaultOrgName { get; set; }
    }
}