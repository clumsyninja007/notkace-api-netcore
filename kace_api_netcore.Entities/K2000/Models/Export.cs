namespace kace_api_netcore.Entities.K2000.Models
{
    public class Export
    {
        public long Id { get; set; }
        public long TargetId { get; set; }
        public string Status { get; set; }
        public string TargetType { get; set; }
        public long CronId { get; set; }
        public byte? Removable { get; set; }
    }
}