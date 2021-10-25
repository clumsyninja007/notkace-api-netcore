namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetHierarchy
    {
        public long ChildAssetId { get; set; }
        public long ParentAssetId { get; set; }
        public string Path { get; set; }
    }
}