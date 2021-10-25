using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImBootAction
    {
        public long Id { get; set; }
        public byte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public byte ScheduleType { get; set; }
        public long? ImDeploymentId { get; set; }
        public long UsmtTemplateId { get; set; }
        public byte OfflineUsmtDeployOption { get; set; }
        public long ImCronId { get; set; }
        public byte MulticastDeployment { get; set; }
        public long? FromRemoteSiteId { get; set; }
        public string Notes { get; set; }
    }
}