using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImTaskGroup
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public string RuntimeEnvironment { get; set; }
        public string Notes { get; set; }
    }
}