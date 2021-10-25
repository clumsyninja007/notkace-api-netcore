using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class KboxLicense
    {
        public long Id { get; set; }
        public string LicenseKey { get; set; }
        public string ActivationStatus { get; set; }
        public DateTime ActivationTime { get; set; }
    }
}