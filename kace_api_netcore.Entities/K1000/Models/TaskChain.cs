using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class TaskChain
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Enabled { get; set; }
        public byte RunLoggedOff { get; set; }
        public byte QueueDisconnected { get; set; }
        public byte TargetAllMachines { get; set; }
        public long? ImCronId { get; set; }
    }
}