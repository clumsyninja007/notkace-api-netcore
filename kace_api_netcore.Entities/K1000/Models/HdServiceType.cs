namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdServiceType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Ordinal { get; set; }
        public short IsSystem { get; set; }
        public short RequiresApproval { get; set; }
    }
}