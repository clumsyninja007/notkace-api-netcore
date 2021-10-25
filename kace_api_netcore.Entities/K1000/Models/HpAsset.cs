using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HpAsset
    {
        public string Serial { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
    }
}