namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImInstallationSourceFingerprints
    {
        public long Id { get; set; }
        public string Family { get; set; }
        public string SubFamily { get; set; }
        public string Version { get; set; }
        public string Signatures { get; set; }
        public string VersionFile { get; set; }
        public string VersionFileRegex { get; set; }
        public string KernelArch { get; set; }
        public string KernelArchRegex { get; set; }
        public string SupportedArches { get; set; }
        public string KernelFile { get; set; }
        public string InitrdFile { get; set; }
        public string DefaultAutoinstall { get; set; }
    }
}