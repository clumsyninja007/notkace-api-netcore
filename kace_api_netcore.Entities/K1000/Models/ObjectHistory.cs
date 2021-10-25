using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ObjectHistory
    {
        public long Id { get; set; }
        public string TypeName { get; set; }
        public long ObjectId { get; set; }
        public string Name { get; set; }
        public DateTime? Time { get; set; }
        public long UserId { get; set; }
        public string UserText { get; set; }
        public string ChangeType { get; set; }
        public string FieldName { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}