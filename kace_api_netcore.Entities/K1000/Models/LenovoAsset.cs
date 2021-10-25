using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class LenovoAsset
    {
        public string Serial { get; set; }
        public string Product { get; set; }
        public string InWarranty { get; set; }
        public DateTimeOffset Purchased { get; set; }
        public DateTimeOffset Shipped { get; set; }
        public string Country { get; set; }
        public string UpgradeUrl { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
    }
}