using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImDeletedNode
    {
        public long Id { get; set; }
        public long ImNodeId { get; set; }
        public DateTimeOffset DateDeleted { get; set; }
        public long UserId { get; set; }
    }
}