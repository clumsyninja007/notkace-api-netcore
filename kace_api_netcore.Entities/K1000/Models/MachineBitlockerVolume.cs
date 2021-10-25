namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineBitlockerVolume
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public string PersistentVolumeId { get; set; }
        public string DriveLetter { get; set; }
        public byte IsSystemVolume { get; set; }
        public string ProtectionStatus { get; set; }
        public int Version { get; set; }
        public string IdentificationField { get; set; }
        public string EncryptionMethod { get; set; }
        public string SelfEncryptionDriveEncryptionMethod { get; set; }
        public string HardwareEncryptionStatus { get; set; }
        public string LockStatus { get; set; }
        public string ConversionStatus { get; set; }
        public int? EncryptionPercentage { get; set; }
        public string WipingStatus { get; set; }
        public int? WipingPercentage { get; set; }
        public string KeyProtectors { get; set; }
    }
}