using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SnmpInventorySettings
    {
        public SnmpInventorySettings()
        {
            SnmpInventoryOids = new HashSet<SnmpInventoryOids>();
            SnmpInventorySettingsJt = new HashSet<SnmpInventorySettingsJt>();
        }

        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public long AssetSubtypeId { get; set; }
        public byte IsDefault { get; set; }

        public virtual ICollection<SnmpInventoryOids> SnmpInventoryOids { get; set; }
        public virtual ICollection<SnmpInventorySettingsJt> SnmpInventorySettingsJt { get; set; }
    }
}