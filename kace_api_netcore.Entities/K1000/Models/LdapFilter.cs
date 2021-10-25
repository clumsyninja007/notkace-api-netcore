using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class LdapFilter
    {
        public long Id { get; set; }
        public long? Enabled { get; set; }
        public string Dn { get; set; }
        public string SearchFilter { get; set; }
        public string ExternalServer { get; set; }
        public long? Port { get; set; }
        public string LdapLogin { get; set; }
        public byte[] LdapPasswordEnc { get; set; }
        public long? LabelId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Type { get; set; }
        public string MemberOfAttrib { get; set; }
        public string LabelPrefix { get; set; }
    }
}