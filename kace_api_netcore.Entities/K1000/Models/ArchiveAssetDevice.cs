namespace kace_api_netcore.Entities.K1000.Models
{
    public class ArchiveAssetDevice
    {
        public long Id { get; set; }
        public long AssetId { get; set; }
        public string Name { get; set; }
        public string HardwareJson { get; set; }
        public string SoftwareJson { get; set; }
        public string RelatedJson { get; set; }
    }
}