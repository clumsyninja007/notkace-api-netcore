namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImNodeHardwareDevices
    {
        public long ImNodeId { get; set; }
        public string DeviceName { get; set; }
        public string InstanceId { get; set; }
        public string HardwareIds { get; set; }
        public string CompatibleIds { get; set; }
        public byte Upgraded { get; set; }
    }
}