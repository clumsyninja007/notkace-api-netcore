namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineDdpeVolume
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public string ProtectionStatus { get; set; }
        public string ProtectionReason { get; set; }
    }
}