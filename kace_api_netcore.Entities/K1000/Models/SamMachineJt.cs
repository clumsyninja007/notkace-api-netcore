namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamMachineJt
    {
        public long MachineId { get; set; }
        public string SamCatalogId { get; set; }
        public string MinorVersion { get; set; }
        public byte MaxVersion { get; set; }
        public string SuiteId { get; set; }
        public byte AppV { get; set; }
    }
}