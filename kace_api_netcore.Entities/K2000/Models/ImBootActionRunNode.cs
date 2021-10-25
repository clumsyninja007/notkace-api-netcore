namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImBootActionRunNode
    {
        public long Id { get; set; }
        public long? ImBootActionRunId { get; set; }
        public long? ImNodeId { get; set; }
        public byte Booted { get; set; }
    }
}