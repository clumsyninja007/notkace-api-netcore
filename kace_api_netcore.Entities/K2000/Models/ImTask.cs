using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImTask
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string RuntimeEnvironment { get; set; }
        public string Filename { get; set; }
        public string CommandLine { get; set; }
        public string Notes { get; set; }
        public long? Filesize { get; set; }
        public long RemoteSiteSize { get; set; }
        public string DownloadStatus { get; set; }
        public long? AccessLevel { get; set; }
        public byte? Hidden { get; set; }
        public byte? RebootRequired { get; set; }
        public long? K1LinkId { get; set; }
        public string K1OrgName { get; set; }
        public long? K1MiId { get; set; }
        public string K1DisplayVersion { get; set; }
        public byte? K1AutoUpdate { get; set; }
        public long ImTaskTypeId { get; set; }
    }
}