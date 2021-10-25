namespace kace_api_netcore.Entities.K1000.Models
{
    public class EmailEvent
    {
        public string ObjectType { get; set; }
        public long ObjectId { get; set; }
        public string Recipient { get; set; }
        public string Event { get; set; }
    }
}