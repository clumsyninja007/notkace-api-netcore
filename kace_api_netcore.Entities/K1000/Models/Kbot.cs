using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Kbot
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public byte Enabled { get; set; }
        public string Status { get; set; }
        public byte RunDisconnected { get; set; }
        public byte RunLoggedOff { get; set; }
        public byte TargetAllMachines { get; set; }
        public byte NotifyAdmins { get; set; }
        public string ScheduleType { get; set; }
        public long? ImCronId { get; set; }
        public string CachedParseError { get; set; }
        public byte RunInventory { get; set; }
        public byte RunAs { get; set; }
        public long RunAsCredentialId { get; set; }
        public byte AlertEnabled { get; set; }
        public string AlertDialogOptions { get; set; }
        public short? AlertDialogTimeout { get; set; }
        public short? AlertSnoozeDuration { get; set; }
        public string AlertMessage { get; set; }
        public string AlertDialogTimeoutAction { get; set; }
        public byte QueueDisconnected { get; set; }
    }
}