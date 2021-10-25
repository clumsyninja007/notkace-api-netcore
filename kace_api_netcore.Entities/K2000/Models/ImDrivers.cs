using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImDrivers
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public long ImInstallationSourceTypeId { get; set; }
        public string Directory { get; set; }
        public long RemoteSiteSize { get; set; }
    }
}