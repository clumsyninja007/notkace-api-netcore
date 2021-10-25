namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdField
    {
        public long Id { get; set; }
        public long HdQueueId { get; set; }
        public string Name { get; set; }
        public string HdTicketFieldName { get; set; }
        public long Ordinal { get; set; }
        public string RequiredState { get; set; }
        public string FieldLabel { get; set; }
        public string Visible { get; set; }
    }
}