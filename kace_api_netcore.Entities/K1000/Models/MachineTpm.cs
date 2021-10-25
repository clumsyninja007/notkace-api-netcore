namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineTpm
    {
        public long Id { get; set; }
        public int ManufacturerId { get; set; }
        public string ManufacturerIdText { get; set; }
        public string ManufacturerVersion { get; set; }
        public string ManufacturerVersionInfo { get; set; }
        public string SpecificationVersion { get; set; }
        public string PhysicalPresenceVersionInfo { get; set; }
        public byte IsEnabled { get; set; }
        public byte IsActivated { get; set; }
        public byte IsOwned { get; set; }
    }
}