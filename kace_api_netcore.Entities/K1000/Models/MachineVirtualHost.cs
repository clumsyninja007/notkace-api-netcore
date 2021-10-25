using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineVirtualHost
    {
        public MachineVirtualHost()
        {
            MachineVirtualGuest = new HashSet<MachineVirtualGuest>();
        }

        public long MachineVirtualHostId { get; set; }
        public long Id { get; set; }
        public long? MachineVirtualManagerId { get; set; }
        public string MachineVirtualManagerName { get; set; }
        public byte MachineVirtualStatusId { get; set; }
        public byte MachineVirtualTypeId { get; set; }
        public string InstanceUuid { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }

        public virtual Machine IdNavigation { get; set; }
        public virtual MachineVirtualManager MachineVirtualManager { get; set; }
        public virtual MachineVirtualStatus MachineVirtualStatus { get; set; }
        public virtual MachineVirtualType MachineVirtualType { get; set; }
        public virtual ICollection<MachineVirtualGuest> MachineVirtualGuest { get; set; }
    }
}