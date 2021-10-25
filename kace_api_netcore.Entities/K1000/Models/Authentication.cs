using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Authentication
    {
        public long Id { get; set; }
        public long? AuthType { get; set; }
        public string Dn { get; set; }
        public string SearchFilter { get; set; }
        public string ExternalServer { get; set; }
        public long? Port { get; set; }
        public long? RequiresSsl { get; set; }
        public string LdapLogin { get; set; }
        public byte[] LdapPasswordEnc { get; set; }
        public string LdapEncryption { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Name { get; set; }
        public long? RoleId { get; set; }
        public long Ordinal { get; set; }
    }
}