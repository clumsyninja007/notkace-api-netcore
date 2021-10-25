namespace kace_api_netcore.Entities.K2000.Models
{
    public class Restore
    {
        public long Id { get; set; }
        public string Status { get; set; }
        public string FileName { get; set; }
        public byte IsManagedInstallImport { get; set; }
        public long? LinkedApplianceId { get; set; }
        public string OrgName { get; set; }
        public long? ManagedInstallId { get; set; }
        public long? ManagedInstallSize { get; set; }
    }
}