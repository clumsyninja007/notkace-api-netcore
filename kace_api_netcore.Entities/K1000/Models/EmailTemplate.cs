namespace kace_api_netcore.Entities.K1000.Models
{
    public class EmailTemplate
    {
        public long Id { get; set; }
        public string ObjectType { get; set; }
        public long ObjectId { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public byte Markdown { get; set; }
    }
}