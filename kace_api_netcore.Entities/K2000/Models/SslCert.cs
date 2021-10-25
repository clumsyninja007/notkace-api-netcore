using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class SslCert
    {
        public int Id { get; set; }
        public string Cert { get; set; }
        public byte Selfsigned { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}