using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserHistory
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public long? MachineId { get; set; }
        public long? PkgId { get; set; }
        public long? KbotRunId { get; set; }
        public string PkgName { get; set; }
        public string PkgVersion { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}