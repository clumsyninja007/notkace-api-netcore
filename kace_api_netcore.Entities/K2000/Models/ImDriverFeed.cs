using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImDriverFeed
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Path { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public long ImInstallationSourceTypeId { get; set; }
        public string PayloadUrl { get; set; }
        public string PayloadChecksum { get; set; }
        public long PayloadSize { get; set; }
        public DateTime? PayloadUpdated { get; set; }
        public string PayloadPathRegex { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string CurrentVersion { get; set; }
        public string InstalledVersion { get; set; }
        public byte Updated { get; set; }
    }
}