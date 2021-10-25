using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImRemoteSite
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public long LinkedApplianceId { get; set; }
        public string SerialNumber { get; set; }
        public long? ImCronId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public byte BandwidthLimitEnabled { get; set; }
        public int BandwidthLimit { get; set; }
        public DateTime? LastSync { get; set; }
        public string Ssh2DsaHostKey { get; set; }
        public string Ssh2RsaHostKey { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string UpgradeStatus { get; set; }
        public DateTime? LastCheck { get; set; }
        public string Version { get; set; }
        public string SyncProgress { get; set; }
    }
}