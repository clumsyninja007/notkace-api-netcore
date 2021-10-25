using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Label
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public string KaceAltLocation { get; set; }
        public string KaceAltLocationUser { get; set; }
        public byte[] KaceAltLocationPasswordEnc { get; set; }
        public string Type { get; set; }
        public byte UsageNode { get; set; }
        public byte UsageAll { get; set; }
        public byte UsageDell { get; set; }
        public byte UsageLabel { get; set; }
        public byte UsageUser { get; set; }
        public byte UsageProcess { get; set; }
        public byte UsagePatch { get; set; }
        public byte UsageSoftware { get; set; }
        public byte UsageMachine { get; set; }
        public byte MeterEnabled { get; set; }
        public byte UsageCatalog { get; set; }
        public byte AppCtrlEnabled { get; set; }
        public long ScopeUserRoleId { get; set; }
    }
}