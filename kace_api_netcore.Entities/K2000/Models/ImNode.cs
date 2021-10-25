using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImNode
    {
        public long Id { get; set; }
        public sbyte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }
        public string HostName { get; set; }
        public sbyte PingProbeResult { get; set; }
        public sbyte PxeProbeResult { get; set; }
        public string PortProbeResult { get; set; }
        public string Platform { get; set; }
        public string Firmware { get; set; }
        public string Notes { get; set; }
        public DateTimeOffset RecoveryConsoleBootTime { get; set; }

        public virtual ICollection<ImDeploymentLog> ImDeploymentLogs { get; set; }
    }
}