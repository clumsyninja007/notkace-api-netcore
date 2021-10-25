using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class FsMachineJt
    {
        public long FsId { get; set; }
        public long MachineId { get; set; }
        public DateTime DownloadTime { get; set; }
    }
}