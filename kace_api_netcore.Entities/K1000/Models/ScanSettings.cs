using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScanSettings
    {
        public long Id { get; set; }
        public string IpRange { get; set; }
        public long? DnsLookupEnabled { get; set; }
        public string DnsServer { get; set; }
        public long? DnsTimeout { get; set; }
        public long? SnmpTestEnabled { get; set; }
        public long? CredentialIdSnmp { get; set; }
        public long? CredentialIdSnmpv3 { get; set; }
        public long? SnmpTimeout { get; set; }
        public long? SnmpRetry { get; set; }
        public long? SocketTestPort { get; set; }
        public long? SocketTestTimeout { get; set; }
        public string SocketTestProtocol { get; set; }
        public long? SocketTestEnabled { get; set; }
        public long? PingTestEnabled { get; set; }
        public long? PortScanEnabled { get; set; }
        public long? PortScanTimeout { get; set; }
        public DateTimeOffset Modified { get; set; }
        public short? Enabled { get; set; }
        public string TcpPortList { get; set; }
        public string UdpPortList { get; set; }
        public string Name { get; set; }
        public byte? SnmpWalkEnabled { get; set; }
        public byte? LdapTestEnabled { get; set; }
        public string LdapServer { get; set; }
        public string LdapUser { get; set; }
        public byte[] LdapPwdEnc { get; set; }
        public string LdapContext { get; set; }
        public byte? NmapEnabled { get; set; }
        public long? NmapTimeout { get; set; }
        public byte? NmapFast { get; set; }
        public byte? NmapOsDetect { get; set; }
        public byte? NmapTcpScan { get; set; }
        public byte? NmapUdpScan { get; set; }
        public byte? CliEnabled { get; set; }
        public long? CliTimeout { get; set; }
        public long? CredentialIdCli { get; set; }
        public byte? GChromeosEnabled { get; set; }
        public byte? GMobileEnabled { get; set; }
        public long? CredentialIdGSuite { get; set; }
        public byte? GSuiteAutoProvision { get; set; }
        public byte? KmmEnabled { get; set; }
        public string KmmRealm { get; set; }
        public long? CredentialIdKmm { get; set; }
        public byte? KmmAutoProvision { get; set; }
        public byte? AwEnabled { get; set; }
        public string AwHost { get; set; }
        public byte[] AwKeyEnc { get; set; }
        public long? CredentialIdAw { get; set; }
        public byte? AwAutoProvision { get; set; }
        public byte? WinrmEnabled { get; set; }
        public long? WinrmTimeout { get; set; }
        public long? WinrmPort { get; set; }
        public byte? WinrmRequireKerberos { get; set; }
        public long? CredentialIdWinrm { get; set; }
        public long? CredentialIdVmware { get; set; }
        public byte? VmwareEnabled { get; set; }
        public long? VmwareTimeout { get; set; }
        public short? Tid { get; set; }
        public long? NodesInScan { get; set; }
        public byte? ScanState { get; set; }
        public string Notify { get; set; }
        public DateTimeOffset Created { get; set; }
        public long? Progress { get; set; }
        public int? LogLevel { get; set; }
        public byte? RelayEnabled { get; set; }
        public long? RelayMachineId { get; set; }

        public virtual Machine RelayMachine { get; set; }
    }
}