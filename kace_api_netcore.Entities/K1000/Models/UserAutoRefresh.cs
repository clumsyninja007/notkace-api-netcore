namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserAutoRefresh
    {
        public long UserId { get; set; }
        public string Page { get; set; }
        public long? AutoRefreshInterval { get; set; }
    }
}