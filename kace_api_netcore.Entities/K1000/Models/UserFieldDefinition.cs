using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserFieldDefinition
    {
        public UserFieldDefinition()
        {
            UserFieldValue = new HashSet<UserFieldValue>();
        }

        public long Id { get; set; }
        public string FieldName { get; set; }
        public long Ordinal { get; set; }
        public string DefaultValue { get; set; }
        public int Required { get; set; }

        public virtual ICollection<UserFieldValue> UserFieldValue { get; set; }
    }
}