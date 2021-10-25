using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImLogImageCapture
    {
        public long LogId { get; set; }
        public long ImNodeId { get; set; }
        public long ImDeploymentId { get; set; }
        public DateTime? CaptureStarted { get; set; }
        public DateTime? CaptureCompleted { get; set; }
        public string ServerIp { get; set; }
    }
}