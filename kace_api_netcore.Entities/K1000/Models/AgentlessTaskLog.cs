using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class AgentlessTaskLog
    {
        public long AgentlessTaskLogId { get; set; }
        public string Kuid { get; set; }
        public string TaskType { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public int MessageCode { get; set; }
        public string MessageVars { get; set; }

        public virtual Machine Ku { get; set; }
    }
}