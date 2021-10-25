namespace kace_api_netcore.Entities.K1000.Models
{
    public class ManufacturerWarrantyApiKeys
    {
        public byte ManufacturerId { get; set; }
        public byte[] KeyEnc { get; set; }
        public byte[] SecretEnc { get; set; }
    }
}