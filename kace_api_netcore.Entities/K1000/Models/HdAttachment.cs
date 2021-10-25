namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdAttachment
    {
        public long Id { get; set; }
        public long? HdTicketChangeId { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string Checksum { get; set; }
    }
}