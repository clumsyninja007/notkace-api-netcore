using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImLogRecoveryConsoleBoot
    {
        public long LogId { get; set; }
        public long ImNodeId { get; set; }
        public long ImDeploymentId { get; set; }
        public DateTime? BootTime { get; set; }
        public string ServerIp { get; set; }
    }
}