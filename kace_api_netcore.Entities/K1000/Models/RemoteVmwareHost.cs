namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteVmwareHost
    {
        public long RemoteVmwareHostId { get; set; }
        public long? RemoteHostId { get; set; }
        public byte VmwareType { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}