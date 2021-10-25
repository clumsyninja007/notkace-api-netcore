using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineVirtualStatus
    {
        public MachineVirtualStatus()
        {
            MachineVirtualGuest = new HashSet<MachineVirtualGuest>();
            MachineVirtualHost = new HashSet<MachineVirtualHost>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MachineVirtualGuest> MachineVirtualGuest { get; set; }
        public virtual ICollection<MachineVirtualHost> MachineVirtualHost { get; set; }
    }
}