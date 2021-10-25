namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserProfileFields
    {
        public long Id { get; set; }
        public string FieldId { get; set; }
        public int? EditMask { get; set; }
        public int? VisibleMask { get; set; }
        public long Ordinal { get; set; }
    }
}