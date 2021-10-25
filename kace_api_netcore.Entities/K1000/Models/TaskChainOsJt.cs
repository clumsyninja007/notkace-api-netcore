namespace kace_api_netcore.Entities.K1000.Models
{
    public class TaskChainOsJt
    {
        public long Id { get; set; }
        public long TaskChainId { get; set; }
        public string SelectionType { get; set; }
        public long OsFamilyId { get; set; }
        public long OsProductId { get; set; }
        public string OsArch { get; set; }
        public long OsId { get; set; }
    }
}