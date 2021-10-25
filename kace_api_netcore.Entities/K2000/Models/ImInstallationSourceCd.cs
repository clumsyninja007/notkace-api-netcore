using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImInstallationSourceCd
    {
        public long ImInstallationSourceId { get; set; }
        public long Number { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Path { get; set; }
        public string Md5Checksum { get; set; }
        public string Sha1Checksum { get; set; }
        public long Size { get; set; }
        public string Status { get; set; }
    }
}