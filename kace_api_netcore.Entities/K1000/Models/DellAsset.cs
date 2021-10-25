using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DellAsset
    {
        public string ServiceTag { get; set; }
        public string ParentServiceTag { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string ItemClassCode { get; set; }
        public string MachineDescription { get; set; }
        public DateTimeOffset ShipDate { get; set; }
        public string CountryLookupCode { get; set; }
        public long CustomerNumber { get; set; }
        public long OrderNumber { get; set; }
        public string LocalChannel { get; set; }
        public int? Disabled { get; set; }
    }
}