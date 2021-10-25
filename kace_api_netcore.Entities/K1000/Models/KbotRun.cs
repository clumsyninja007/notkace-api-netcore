using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KbotRun
    {
        public long Id { get; set; }
        public DateTime StartTime { get; set; }
        public string Description { get; set; }
        public long KbotId { get; set; }
        public string KbotVersion { get; set; }
        public string KbotXml { get; set; }
        public long Serial { get; set; }
        public long UserId { get; set; }
    }
}