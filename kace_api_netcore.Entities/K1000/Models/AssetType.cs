using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetType
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public string AssetCategory { get; set; }
        public int IsHierarchy { get; set; }
        public string MappedTable { get; set; }
        public string DetailPage { get; set; }
        public string AssetMapField { get; set; }
        public string MappedField { get; set; }
        public int Ignored { get; set; }
        public string BarcodeTagValues { get; set; }
        public long? DefaultAssetStatusId { get; set; }
        public long? DefaultArchiveAssetStatusId { get; set; }
    }
}