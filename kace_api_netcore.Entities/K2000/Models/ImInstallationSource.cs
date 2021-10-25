using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImInstallationSource
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public long ImInstallationSourceTypeId { get; set; }
        public long TotalCds { get; set; }
        public long RemoteSiteSize { get; set; }
        public long ImInstallationSourceCategoryId { get; set; }
        public long? BootEnvironmentId { get; set; }
    }
}