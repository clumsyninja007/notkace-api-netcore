using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineLocation
    {
        public long MachineLocationId { get; set; }
        public long Id { get; set; }
        public string StreetAddress { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Counrty { get; set; }
        public string CountryCode { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTimeOffset? LastUpdate { get; set; }

        public virtual Machine IdNavigation { get; set; }
    }
}