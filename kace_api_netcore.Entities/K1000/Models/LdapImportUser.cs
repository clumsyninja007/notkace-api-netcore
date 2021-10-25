namespace kace_api_netcore.Entities.K1000.Models
{
    public class LdapImportUser
    {
        public long Id { get; set; }
        public string Dn { get; set; }
        public string SearchFilter { get; set; }
        public string ExternalServer { get; set; }
        public long? Port { get; set; }
        public string LdapLogin { get; set; }
        public byte[] LdapPasswordEnc { get; set; }
        public string Attrib { get; set; }
        public string LabelAttrib { get; set; }
        public string LabelPrefix { get; set; }
        public string BinAttrib { get; set; }
        public long? RowLimit { get; set; }
        public string Mapping { get; set; }
    }
}