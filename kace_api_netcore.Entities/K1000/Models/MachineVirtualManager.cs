using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineVirtualManager
    {
        public MachineVirtualManager()
        {
            MachineVirtualHost = new HashSet<MachineVirtualHost>();
        }

        public long MachineVirtualManagerId { get; set; }
        public long Id { get; set; }
        public byte MachineVirtualTypeId { get; set; }
        public string InstanceUuid { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }

        public virtual Machine IdNavigation { get; set; }
        public virtual MachineVirtualType MachineVirtualType { get; set; }
        public virtual ICollection<MachineVirtualHost> MachineVirtualHost { get; set; }
    }
}