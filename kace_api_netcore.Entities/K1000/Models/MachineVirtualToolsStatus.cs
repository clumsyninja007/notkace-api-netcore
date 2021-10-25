﻿using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineVirtualToolsStatus
    {
        public MachineVirtualToolsStatus()
        {
            MachineVirtualGuest = new HashSet<MachineVirtualGuest>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MachineVirtualGuest> MachineVirtualGuest { get; set; }
    }
}