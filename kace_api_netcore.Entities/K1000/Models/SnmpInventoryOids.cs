using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SnmpInventoryOids
    {
        public long Id { get; set; }
        public long SnmpInventorySettingsId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Mib { get; set; }
        public string Oid { get; set; }
        public string Category { get; set; }
        public string Property { get; set; }
        public string TableName { get; set; }
        public string OidInternalMap { get; set; }
        public string OidExternalMap { get; set; }
        public long Ordinal { get; set; }

        public virtual SnmpInventorySettings SnmpInventorySettings { get; set; }
    }
}