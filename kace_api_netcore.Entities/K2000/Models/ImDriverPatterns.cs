namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImDriverPatterns
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public long ImInstallationSourceTypeId { get; set; }
        public string Pattern { get; set; }
    }
}