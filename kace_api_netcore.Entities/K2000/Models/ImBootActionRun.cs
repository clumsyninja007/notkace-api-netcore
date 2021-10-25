using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImBootActionRun
    {
        public long Id { get; set; }
        public long? ImBootActionId { get; set; }
        public DateTime? DeployStarted { get; set; }
        public DateTime? DeployCompleted { get; set; }
        public byte Scheduled { get; set; }
        public string Status { get; set; }
    }
}