namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineDriveEncryptionSummary
    {
        public long Id { get; set; }
        public byte IsDriveEncryptionEnabled { get; set; }
        public byte IsDriveProtected { get; set; }
        public string ProtectionReason { get; set; }
    }
}