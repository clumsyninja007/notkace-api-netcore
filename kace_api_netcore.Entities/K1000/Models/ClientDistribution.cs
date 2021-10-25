using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ClientDistribution
    {
        public long Id { get; set; }
        public string Label { get; set; }
        public DateTimeOffset Modified { get; set; }
        public string Notes { get; set; }
        public long? Enabled { get; set; }
        public string DistKey { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string Version { get; set; }
        public byte UpdateUnknownMachines { get; set; }
        public string Family { get; set; }
        public byte TargetAllMachines { get; set; }
        public byte DontReplicate { get; set; }
    }
}