namespace kace_api_netcore.Entities.K1000.Models
{
    public class OperatingSystems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CommonName { get; set; }
        public long? Managed { get; set; }
        public string Description { get; set; }
        public int? MajorVersion { get; set; }
        public int? MinorVersion { get; set; }
        public string Build { get; set; }
        public int? Sp { get; set; }
        public string Family { get; set; }
        public int? Minor2Version { get; set; }
        public string Arch { get; set; }
        public long? PatchlinkOsTypeId { get; set; }
        public long? OsFamilyId { get; set; }
        public long OsProductId { get; set; }
    }
}