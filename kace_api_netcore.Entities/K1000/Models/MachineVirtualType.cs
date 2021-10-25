using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineVirtualType
    {
        public MachineVirtualType()
        {
            MachineVirtualGuest = new HashSet<MachineVirtualGuest>();
            MachineVirtualHost = new HashSet<MachineVirtualHost>();
            MachineVirtualManager = new HashSet<MachineVirtualManager>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MachineVirtualGuest> MachineVirtualGuest { get; set; }
        public virtual ICollection<MachineVirtualHost> MachineVirtualHost { get; set; }
        public virtual ICollection<MachineVirtualManager> MachineVirtualManager { get; set; }
    }
}