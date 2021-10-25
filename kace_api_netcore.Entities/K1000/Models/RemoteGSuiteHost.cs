namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteGSuiteHost
    {
        public long RemoteGSuiteHostId { get; set; }
        public long RemoteHostId { get; set; }
        public string ResourceId { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}