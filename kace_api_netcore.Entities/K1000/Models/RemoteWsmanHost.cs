namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteWsmanHost
    {
        public long RemoteWsmanHostId { get; set; }
        public long RemoteHostId { get; set; }
        public int? Port { get; set; }
        public string Transport { get; set; }
        public byte RequireKerberos { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}