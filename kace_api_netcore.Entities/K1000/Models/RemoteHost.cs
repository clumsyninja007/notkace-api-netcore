using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class RemoteHost
    {
        public RemoteHost()
        {
            RemoteAirwatchHost = new HashSet<RemoteAirwatchHost>();
            RemoteChromeosHost = new HashSet<RemoteChromeosHost>();
            RemoteGSuiteHost = new HashSet<RemoteGSuiteHost>();
            RemoteHostKuid = new HashSet<RemoteHostKuid>();
            RemoteKmmHost = new HashSet<RemoteKmmHost>();
            RemoteShellHost = new HashSet<RemoteShellHost>();
            RemoteSnmpHost = new HashSet<RemoteSnmpHost>();
            RemoteVmwareHost = new HashSet<RemoteVmwareHost>();
            RemoteWsmanHost = new HashSet<RemoteWsmanHost>();
            SnmpInventorySettingsJt = new HashSet<SnmpInventorySettingsJt>();
        }

        public long RemoteHostId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string HostName { get; set; }
        public long Protocol { get; set; }
        public long? CredentialId { get; set; }
        public int? LogLevel { get; set; }
        public string DnsServer { get; set; }
        public long? AssetSubtypeId { get; set; }
        public long? RelayMachineId { get; set; }

        public virtual RemoteHostProtocol ProtocolNavigation { get; set; }
        public virtual Machine RelayMachine { get; set; }
        public virtual ICollection<RemoteAirwatchHost> RemoteAirwatchHost { get; set; }
        public virtual ICollection<RemoteChromeosHost> RemoteChromeosHost { get; set; }
        public virtual ICollection<RemoteGSuiteHost> RemoteGSuiteHost { get; set; }
        public virtual ICollection<RemoteHostKuid> RemoteHostKuid { get; set; }
        public virtual ICollection<RemoteKmmHost> RemoteKmmHost { get; set; }
        public virtual ICollection<RemoteShellHost> RemoteShellHost { get; set; }
        public virtual ICollection<RemoteSnmpHost> RemoteSnmpHost { get; set; }
        public virtual ICollection<RemoteVmwareHost> RemoteVmwareHost { get; set; }
        public virtual ICollection<RemoteWsmanHost> RemoteWsmanHost { get; set; }
        public virtual ICollection<SnmpInventorySettingsJt> SnmpInventorySettingsJt { get; set; }
    }
}