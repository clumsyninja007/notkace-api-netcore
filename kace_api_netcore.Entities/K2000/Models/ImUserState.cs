using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImUserState
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string ProfileName { get; set; }
        public string Notes { get; set; }
        public string HostName { get; set; }
        public string Domain { get; set; }
        public long Size { get; set; }
        public long RemoteSiteSize { get; set; }
        public string InstallationSourceType { get; set; }
        public string Arch { get; set; }
        public string UsmtVersion { get; set; }
        public byte? LocalUser { get; set; }
        public long? TemplateId { get; set; }
        public long? RemoteSiteId { get; set; }
    }
}