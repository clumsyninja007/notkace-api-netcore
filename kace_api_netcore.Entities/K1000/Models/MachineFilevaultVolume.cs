namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineFilevaultVolume
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public byte IsEnabled { get; set; }
        public string Version { get; set; }
        public byte HasPersonalRecoveryKey { get; set; }
        public byte HasInstitutionalRecoveryKey { get; set; }
        public string AuthorizedUsers { get; set; }
        public string ConversionStatus { get; set; }
        public int ConversionPercentage { get; set; }
        public string EncryptionStatus { get; set; }
        public string EncryptionType { get; set; }
    }
}