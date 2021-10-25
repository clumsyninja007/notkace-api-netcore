namespace kace_api_netcore.Entities.K1000.Models
{
    public class AssetData1
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string Locale { get; set; }
        public string PhoneNumber { get; set; }
        public long? PrimaryContact { get; set; }
        public long? Parent { get; set; }
        public string Field10007 { get; set; }
    }
}