namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdTicketChangeField
    {
        public long Id { get; set; }
        public long HdTicketChangeId { get; set; }
        public string FieldChanged { get; set; }
        public string BeforeValue { get; set; }
        public string AfterValue { get; set; }
        public string Description { get; set; }
        public string LocalizedDescription { get; set; }
    }
}