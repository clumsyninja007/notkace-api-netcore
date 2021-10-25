using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamAttachedFile
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string SamCatalogId { get; set; }
        public string MinorVersion { get; set; }
        public string FileName { get; set; }
        public long? FileSize { get; set; }
        public string Checksum { get; set; }
        public string Notes { get; set; }
        public byte DontReplicate { get; set; }
    }
}