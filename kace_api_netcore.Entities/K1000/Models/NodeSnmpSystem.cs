using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class NodeSnmpSystem
    {
        public long Id { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
        public string Uptime { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string ObjectId { get; set; }
        public string FullWalk { get; set; }
    }
}