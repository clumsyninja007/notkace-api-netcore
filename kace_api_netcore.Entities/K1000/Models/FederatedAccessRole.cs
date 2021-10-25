namespace kace_api_netcore.Entities.K1000.Models
{
    public class FederatedAccessRole
    {
        public long Id { get; set; }
        public long LinkedApplianceId { get; set; }
        public long UserRoleId { get; set; }
    }
}