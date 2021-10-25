using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImUsmtScanTemplate
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string CmdLine { get; set; }
        public string ExcludeFiles { get; set; }
        public string ExcludeUsers { get; set; }
        public byte? ScanAllUsers { get; set; }
        public string ConfigFile { get; set; }
        public long? RemoteSiteId { get; set; }
    }
}