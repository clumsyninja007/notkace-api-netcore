namespace kace_api_netcore.Entities.K1000.Models
{
    public class Approval
    {
        public long Id { get; set; }
        public string ObjectType { get; set; }
        public long ObjectId { get; set; }
        public long TimeoutMinutes { get; set; }
        public long NotificationRecurrenceMinutes { get; set; }
        public byte UseBusinessHours { get; set; }
    }
}