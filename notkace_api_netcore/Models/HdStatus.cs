namespace notkace_api_netcore.Models
{
    public class HdStatus
    {
        public long Id { get; set; }
        public long HdQueueId { get; set; }
        public string Name { get; set; }
        public long Ordinal { get; set; }
        public string State { get; set; }
    }
}