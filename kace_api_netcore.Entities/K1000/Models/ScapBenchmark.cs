using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScapBenchmark
    {
        public long Id { get; set; }
        public string Identifier { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public DateTime? Updated { get; set; }
        public string XmlFilePrefix { get; set; }
        public string ScapVersion { get; set; }
        public string ChecklistId { get; set; }
        public string DatastreamId { get; set; }
    }
}