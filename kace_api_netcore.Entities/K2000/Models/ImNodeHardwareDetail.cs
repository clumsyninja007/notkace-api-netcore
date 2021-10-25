using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImNodeHardwareDetail
    {
        public long ImNodeId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string BiosName { get; set; }
        public string BiosVersion { get; set; }
        public string BiosManufacturer { get; set; }
        public string BiosDescription { get; set; }
        public string BiosSerialNumber { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string Disk { get; set; }
        public string NetworkAdapter { get; set; }
    }
}