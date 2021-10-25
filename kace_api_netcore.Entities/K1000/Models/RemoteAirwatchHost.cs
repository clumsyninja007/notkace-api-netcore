namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteAirwatchHost
    {
        public long RemoteAirwatchHostId { get; set; }
        public long? RemoteHostId { get; set; }
        public string AwId { get; set; }
        public string ServiceHost { get; set; }
        public byte[] ApiKeyEnc { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}