namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdCustomFields
    {
        public int Id { get; set; }
        public int HdQueueId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Values { get; set; }
        public string Default { get; set; }
        public byte OwnersOnly { get; set; }
        public byte OwnersOnlyRead { get; set; }
    }
}