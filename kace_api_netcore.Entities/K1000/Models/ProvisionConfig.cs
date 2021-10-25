using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ProvisionConfig
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? CredentialIdWin { get; set; }
        public int? CredentialIdMac { get; set; }
        public int? CredentialIdLinux { get; set; }
        public short? Enabled { get; set; }
        public short? RemoveEnabled { get; set; }
        public short? AndRemoveKuid { get; set; }
        public string IpRange { get; set; }
        public long? DnsLookupEnabled { get; set; }
        public string DnsServer { get; set; }
        public long? DnsTimeout { get; set; }
        public string KboxServerName { get; set; }
        public string KboxClientShareName { get; set; }
        public long? WindowsAgentPort { get; set; }
        public string WindowsPortList { get; set; }
        public long? WindowsScanTimeout { get; set; }
        public long? WindowsPortBypass { get; set; }
        public byte? WinTryWinrm { get; set; }
        public int? WinWinrmPort { get; set; }
        public string UnixPortList { get; set; }
        public long? UnixScanTimeout { get; set; }
        public long? UnixPortBypass { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string IpList { get; set; }
        public string Type { get; set; }
        public short? Debug { get; set; }
        public string HostnameList { get; set; }
        public DateTimeOffset LastRun { get; set; }
        public int? LogLevel { get; set; }
        public long? RelayMachineId { get; set; }

        public virtual Machine RelayMachine { get; set; }
    }
}