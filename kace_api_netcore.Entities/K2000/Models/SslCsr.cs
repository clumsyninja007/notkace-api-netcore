using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class SslCsr
    {
        public int Id { get; set; }
        public string Countryname { get; set; }
        public string Statename { get; set; }
        public string Localityname { get; set; }
        public string Orgname { get; set; }
        public string Unitname { get; set; }
        public string Commonname { get; set; }
        public string Email { get; set; }
        public DateTimeOffset Updated { get; set; }
        public string Request { get; set; }
    }
}