namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteSnmpHost
    {
        public long RemoteSnmpHostId { get; set; }
        public long RemoteHostId { get; set; }
        public int SnmpVersion { get; set; }
        public int? DeviceType { get; set; }
        public int InventoryType { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}