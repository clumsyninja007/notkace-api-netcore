using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImDeploymentLog
    {
        public long LogId { get; set; }
        public long ImNodeId { get; set; }
        public long ImDeploymentId { get; set; }
        public long ImBootActionRunId { get; set; }
        public DateTime? DeployStarted { get; set; }
        public DateTime? DeployCompleted { get; set; }
        public string ServerIp { get; set; }
        public string Status { get; set; }

        public virtual ImNode ImNode { get; set; }
        public virtual ImDeployment ImDeployment { get; set; }
    }
}