namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteChromeosHost
    {
        public long RemoteChromeosHostId { get; set; }
        public long RemoteHostId { get; set; }
        public string ChromeosId { get; set; }

        public virtual RemoteHost RemoteHost { get; set; }
    }
}