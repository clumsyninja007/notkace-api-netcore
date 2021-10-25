namespace kace_api_netcore.Entities.K1000.Models
{
    public class DellMachineStatus
    {
        public long MachineId { get; set; }
        public long CatalogId { get; set; }
        public long DeviceId { get; set; }
        public string PackageDid { get; set; }
        public string ApplicableUpdate { get; set; }
    }
}