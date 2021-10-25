using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Mi
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long? SoftwareId { get; set; }
        public string SamCatalogId { get; set; }
        public long? SamAttachedFileId { get; set; }
        public string SamMinorVersion { get; set; }
        public string Notes { get; set; }
        public long? Enabled { get; set; }
        public string InstallFile { get; set; }
        public string InstallParms { get; set; }
        public long? Snooze { get; set; }
        public long? AdminInstall { get; set; }
        public string SetupMode { get; set; }
        public string RebootMode { get; set; }
        public long? RemoveFiles { get; set; }
        public int? HourBegin { get; set; }
        public int? HourEnd { get; set; }
        public string AltLocation { get; set; }
        public string AltChecksum { get; set; }
        public string PreinstallMessage { get; set; }
        public string PostinstallMessage { get; set; }
        public long? Uninstall { get; set; }
        public long? RunOnly { get; set; }
        public string InstallFullCommandline { get; set; }
        public int? SnoozeTimeout { get; set; }
        public int? PreinstallMessageTimeout { get; set; }
        public int? PostinstallMessageTimeout { get; set; }
        public string SnoozeTimeoutAction { get; set; }
        public string SnoozeMessage { get; set; }
        public int? DeployOrder { get; set; }
        public string PreinstallTimeoutAction { get; set; }
        public long? CredentialIdAltLocation { get; set; }
        public long? MaxAttemptCount { get; set; }
        public byte TargetAllMachines { get; set; }
        public byte DontPrependMsiexec { get; set; }
    }
}