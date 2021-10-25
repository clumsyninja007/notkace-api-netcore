using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetClass
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public byte Protected { get; set; }
        public long AssetTypeId { get; set; }
        public long ParentClassId { get; set; }
        public byte IsDefault { get; set; }
    }
}