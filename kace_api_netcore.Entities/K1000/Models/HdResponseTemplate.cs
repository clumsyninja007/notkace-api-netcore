using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdResponseTemplate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? QueueId { get; set; }
        public string Template { get; set; }
        public short? IsPublic { get; set; }
        public long? CreatedBy { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
    }
}