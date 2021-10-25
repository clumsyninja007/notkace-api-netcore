namespace kace_api_netcore.Entities.K1000.Models
{
    public class SnmpInventorySettingsJt
    {
        public long SnmpInventorySettingsId { get; set; }
        public long RemoteHostId { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
        public virtual SnmpInventorySettings SnmpInventorySettings { get; set; }
    }
}