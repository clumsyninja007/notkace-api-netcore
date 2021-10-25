using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkMachineStatus
    {
        public long MachineId { get; set; }
        public string Patchuid { get; set; }
        public string Status { get; set; }
        public DateTime? StatusDt { get; set; }
        public long DetectErrorCode { get; set; }
        public string DeployStatus { get; set; }
        public DateTime? DeployStatusDt { get; set; }
        public long DeployErrorCode { get; set; }
        public long DeployRcode { get; set; }
        public string DeployRdesc { get; set; }
        public long? DeployAttemptCount { get; set; }
        public string RollbackStatus { get; set; }
        public DateTime? RollbackStatusDt { get; set; }
        public long RollbackErrorCode { get; set; }
        public long RollbackRcode { get; set; }
        public string RollbackRdesc { get; set; }
        public long? RollbackAttemptCount { get; set; }
        public long MaxDeployAttempt { get; set; }
        public long MaxRollbackAttempt { get; set; }
        public long ScheduleId { get; set; }
        public int IsError { get; set; }
    }
}