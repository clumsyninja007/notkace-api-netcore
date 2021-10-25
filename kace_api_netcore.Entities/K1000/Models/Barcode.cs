using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Barcode
    {
        public long Id { get; set; }
        public string BarcodeData { get; set; }
        public string BarcodeName { get; set; }
        public string BarcodeFormat { get; set; }
        public DateTimeOffset FirstScannedDate { get; set; }
        public string FirstScannedMethod { get; set; }
        public string FirstScannedUser { get; set; }
        public string FirstScannedGeolocation { get; set; }
        public DateTimeOffset LastScannedDate { get; set; }
        public string LastScannedMethod { get; set; }
        public string LastScannedUser { get; set; }
        public string LastScannedGeolocation { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}