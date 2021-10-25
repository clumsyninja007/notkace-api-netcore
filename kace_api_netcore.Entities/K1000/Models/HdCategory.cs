namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdCategory
    {
        public long Id { get; set; }
        public long HdQueueId { get; set; }
        public string Name { get; set; }
        public long Ordinal { get; set; }
        public long? DefaultOwnerId { get; set; }
        public string CcList { get; set; }
        public byte UserSettable { get; set; }
    }
}