using System;

namespace kace_api_netcore.Data.K2000.Dtos
{
    public class DeploymentDto
    {
        public string MAC { get; set; }
        public string Name { get; set; }
        public sbyte Deleted { get; set; }
        public long LogId { get; set; }
        public DateTime? DeployStarted { get; set; }
        public DateTime? DeployCompleted { get; set; }
        public string Status { get; set; }
    }
}