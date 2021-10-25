namespace kace_api_netcore.Entities.K1000.Models
{
    public class Dashboard
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string DashboardDef { get; set; }
        public string Page { get; set; }
    }
}