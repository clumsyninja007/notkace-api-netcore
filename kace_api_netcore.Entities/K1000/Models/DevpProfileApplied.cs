using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DevpProfileApplied
    {
        public DevpProfileApplied()
        {
            DevpProfileAppliedMachine = new HashSet<DevpProfileAppliedMachine>();
            DevpProfileAppliedPayload = new HashSet<DevpProfileAppliedPayload>();
        }

        public int Id { get; set; }
        public string ProfileName { get; set; }
        public string Type { get; set; }
        public string Scope { get; set; }
        public byte[] ProfileString { get; set; }
        public string UiFormatter { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
        public long KbotId { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public string Uidentifier { get; set; }

        public virtual ICollection<DevpProfileAppliedMachine> DevpProfileAppliedMachine { get; set; }
        public virtual ICollection<DevpProfileAppliedPayload> DevpProfileAppliedPayload { get; set; }
    }
}