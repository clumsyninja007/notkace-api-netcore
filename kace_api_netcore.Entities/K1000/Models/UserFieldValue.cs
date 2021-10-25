namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserFieldValue
    {
        public long FieldId { get; set; }
        public long UserId { get; set; }
        public string FieldValue { get; set; }

        public virtual UserFieldDefinition Field { get; set; }
    }
}