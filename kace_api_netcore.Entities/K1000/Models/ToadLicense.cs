using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ToadLicense
    {
        public long Id { get; set; }
        public string LicenseKey { get; set; }
        public string Hash { get; set; }
        public byte Processed { get; set; }
        public long? AssetId { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}