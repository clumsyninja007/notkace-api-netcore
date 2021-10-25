namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImBinlDriverCache
    {
        public long ImInstallationSourceTypeId { get; set; }
        public string HardwareClass { get; set; }
        public string HardwareId { get; set; }
        public string DriverPath { get; set; }
        public string InfPath { get; set; }
        public string RequiredFiles { get; set; }
        public string Description { get; set; }
        public string ServiceName { get; set; }
        public string Characteristics { get; set; }
        public string BusType { get; set; }
    }
}