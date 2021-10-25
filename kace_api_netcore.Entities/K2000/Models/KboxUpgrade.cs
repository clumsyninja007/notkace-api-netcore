using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class KboxUpgrade
    {
        public long Id { get; set; }
        public string OldVersion { get; set; }
        public string NewVersion { get; set; }
        public DateTime? UpgradeStarted { get; set; }
        public DateTime? UpgradeCompleted { get; set; }
    }
}