using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte IsSystem { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}