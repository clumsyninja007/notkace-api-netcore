namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserAdditionalEmail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Sorting { get; set; }
        public long UserId { get; set; }
    }
}