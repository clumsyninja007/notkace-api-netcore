using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Message
    {
        public long Id { get; set; }
        public string Message1 { get; set; }
        public long? KeepAlive { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public DateTimeOffset Created { get; set; }
        public byte Deleted { get; set; }
        public long? ImCronId { get; set; }
        public byte TargetAllMachines { get; set; }
    }
}