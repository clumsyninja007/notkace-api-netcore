using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImDeployment
    {
        public long Id { get; set; }
        public sbyte Deleted { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Architecture { get; set; }
        public long Size { get; set; }
        public long? ImNodeId { get; set; }
        public sbyte Dirty { get; set; }
        public DateTime? CaptureStarted { get; set; }
        public DateTime? CaptureCompleted { get; set; }
        public string DeployOptions { get; set; }
        public string Notes { get; set; }
        public string ClassName { get; set; }
        public long? ImInstallationSourceId { get; set; }
        public long RemoteSiteSize { get; set; }
        public sbyte ShowCancel { get; set; }
        public sbyte Sysprepped { get; set; }
        public sbyte ShutdownAfterLastTask { get; set; }
        public sbyte CalculateLogonCount { get; set; }
        public byte AutoLogonCount { get; set; }
        public long? RemoteSiteId { get; set; }
        public sbyte MemdiskBoot { get; set; }
        public sbyte DirectCapture { get; set; }
        public long ImDeploymentTypeId { get; set; }

        public virtual ICollection<ImDeploymentLog> ImDeploymentLogs { get; set; }
    }
}