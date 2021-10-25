namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdEmailEvent
    {
        public long HdQueueId { get; set; }
        public string Recipient { get; set; }
        public string Event { get; set; }
    }
}