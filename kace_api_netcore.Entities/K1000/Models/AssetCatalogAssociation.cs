namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetCatalogAssociation
    {
        public long AssetId { get; set; }
        public long AssetFieldId { get; set; }
        public string AssociatedCatalogId { get; set; }
    }
}