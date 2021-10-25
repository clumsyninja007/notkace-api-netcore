using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineVirtualGuest
    {
        public long MachineVirtualGuestId { get; set; }
        public long Id { get; set; }
        public long? MachineId { get; set; }
        public string Description { get; set; }
        public string Hostname { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public string ToolsVersion { get; set; }
        public int? UsageCpu { get; set; }
        public int? UsageMemory { get; set; }
        public long? UsageDatastore { get; set; }
        public byte MachineVirtualStateId { get; set; }
        public byte MachineVirtualStatusId { get; set; }
        public byte MachineVirtualToolsStatusId { get; set; }
        public byte MachineVirtualTypeId { get; set; }
        public string InstanceUuid { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }

        public virtual MachineVirtualHost IdNavigation { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual MachineVirtualState MachineVirtualState { get; set; }
        public virtual MachineVirtualStatus MachineVirtualStatus { get; set; }
        public virtual MachineVirtualToolsStatus MachineVirtualToolsStatus { get; set; }
        public virtual MachineVirtualType MachineVirtualType { get; set; }
    }
}