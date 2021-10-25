namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImInstallationSourceType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Architecture { get; set; }
        public string BootEnvironmentName { get; set; }
        public byte? IsScriptedInstall { get; set; }
        public byte? IsBootEnv { get; set; }
        public byte? IsWindowsBootEnv { get; set; }
        public string Alias { get; set; }
        public long? ImInstallationSourceFingerprintId { get; set; }
    }
}