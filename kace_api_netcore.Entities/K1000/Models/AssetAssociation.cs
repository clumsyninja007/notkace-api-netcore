namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetAssociation
    {
        public long AssetId { get; set; }
        public long AssetFieldId { get; set; }
        public long AssociatedAssetId { get; set; }
    }
}