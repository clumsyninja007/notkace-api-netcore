namespace kace_api_netcore.Entities.K1000.Models
{
    public class ApprovalStage
    {
        public long Id { get; set; }
        public long ApprovalId { get; set; }
        public byte Stage { get; set; }
        public long Ordinal { get; set; }
        public string ApprovalType { get; set; }
    }
}