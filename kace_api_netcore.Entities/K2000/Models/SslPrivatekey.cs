using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class SslPrivatekey
    {
        public int Id { get; set; }
        public string Privatekey { get; set; }
        public string Cert { get; set; }
        public DateTimeOffset Updated { get; set; }
    }
}