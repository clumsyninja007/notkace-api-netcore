using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KbotRunMachine
    {
        public long KbotRunId { get; set; }
        public long MachineId { get; set; }
        public DateTime? RequestTime { get; set; }
        public string RequestStatus { get; set; }
        public long? KbotLogId { get; set; }
        public long Serial { get; set; }
        public string KbotReplXml { get; set; }
        public long? TaskChainRunId { get; set; }
    }
}