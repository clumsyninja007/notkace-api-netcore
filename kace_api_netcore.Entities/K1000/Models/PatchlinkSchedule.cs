using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkSchedule
    {
        public long Id { get; set; }
        public long? KeepAlive { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public DateTimeOffset Created { get; set; }
        public byte Deleted { get; set; }
        public string PatchAction { get; set; }
        public long? ImCronId { get; set; }
        public string Description { get; set; }
        public string RebootMode { get; set; }
        public string RebootMessage { get; set; }
        public int? RebootTimeout { get; set; }
        public string RebootAction { get; set; }
        public byte TargetAllMachines { get; set; }
        public byte QueueDisconnected { get; set; }
        public byte DetectAllPatches { get; set; }
        public byte DeployAllPatches { get; set; }
        public DateTime? LastRun { get; set; }
        public string KonductorTaskType { get; set; }
        public int RepromptInterval { get; set; }
        public int MaxRunDuration { get; set; }
        public byte MatchMachineLabels { get; set; }
        public int DetectTimeout { get; set; }
        public int DeployTimeout { get; set; }
        public byte RollbackAllPatches { get; set; }
        public int RollbackTimeout { get; set; }
        public int MaxDeployAttempt { get; set; }
        public int MaxRollbackAttempt { get; set; }
        public long AlertId { get; set; }
        public int DelayScheduleBy { get; set; }
        public byte ShowPatchProgress { get; set; }
        public string PatchProgressMessage { get; set; }
        public string PatchCompletedMessage { get; set; }
        public byte LimitPrompt { get; set; }
        public int RepromptCount { get; set; }
        public int RebootDelayInterval { get; set; }
        public byte RebootAuto { get; set; }
        public long? PatchlinkScheduleRunId { get; set; }
    }
}