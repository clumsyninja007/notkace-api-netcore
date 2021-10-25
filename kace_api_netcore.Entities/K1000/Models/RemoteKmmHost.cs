namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteKmmHost
    {
        public long RemoteKmmHostId { get; set; }
        public long RemoteHostId { get; set; }
        public string KmmId { get; set; }
        public string Realm { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}