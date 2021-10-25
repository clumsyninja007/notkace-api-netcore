namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdMailtemplate
    {
        public long Id { get; set; }
        public long HdQueueId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public byte Markdown { get; set; }
    }
}