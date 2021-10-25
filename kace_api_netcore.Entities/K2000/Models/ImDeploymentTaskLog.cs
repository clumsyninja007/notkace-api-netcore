using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImDeploymentTaskLog
    {
        public long Id { get; set; }
        public long ImDeploymentLogId { get; set; }
        public long ImTaskId { get; set; }
        public int? InstallOrder { get; set; }
        public DateTime DateCompleted { get; set; }
        public long ReturnCode { get; set; }
    }
}