using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DellInventory
    {
        public long MachineId { get; set; }
        public string Lang { get; set; }
        public DateTimeOffset Created { get; set; }
        public string SystemDid { get; set; }
        public string OsCode { get; set; }
        public string OsVendor { get; set; }
        public string OsArch { get; set; }
        public int? OsMajver { get; set; }
        public int? OsMinver { get; set; }
        public string InvOutXml { get; set; }
        public string InvLogXml { get; set; }
        public DateTimeOffset Modified { get; set; }
        public string StatusPhase { get; set; }
        public int? StatusCode { get; set; }
    }
}