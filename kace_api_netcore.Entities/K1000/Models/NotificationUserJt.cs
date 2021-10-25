namespace kace_api_netcore.Entities.K1000.Models
{
    public class NotificationUserJt
    {
        public long NotificationId { get; set; }
        public long UserId { get; set; }

        public virtual Notification Notification { get; set; }
    }
}