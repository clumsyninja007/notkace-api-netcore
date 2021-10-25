namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteHostKuid
    {
        public long RemoteHostKuidId { get; set; }
        public long? RemoteHostId { get; set; }
        public string Kuid { get; set; }
        public int? LastResult { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}