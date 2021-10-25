namespace kace_api_netcore.Entities.K1000.Models
{
    public class DellInventoryDeviceJt
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public string ComponentDid { get; set; }
        public string Display { get; set; }
        public string VendorDid { get; set; }
        public string DeviceDid { get; set; }
        public string SubDeviceDid { get; set; }
        public string SubVendorDid { get; set; }
        public string Acpiid { get; set; }
        public string PnpProductId { get; set; }
    }
}