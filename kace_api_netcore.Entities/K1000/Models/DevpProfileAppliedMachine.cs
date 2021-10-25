using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DevpProfileAppliedMachine
    {
        public long Id { get; set; }
        public int? DevpProfileAppliedId { get; set; }
        public int MachineId { get; set; }
        public string ResultLog { get; set; }
        public string Status { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
        public string PayloadUid { get; set; }
        public string User { get; set; }

        public virtual DevpProfileApplied DevpProfileApplied { get; set; }
    }
}