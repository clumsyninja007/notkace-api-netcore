namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamCount
    {
        public string SamCatalogId { get; set; }
        public string SamType { get; set; }
        public long InstalledOn { get; set; }
        public long RecentlyAdded { get; set; }
        public long RecentlyRemoved { get; set; }
    }
}