using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DevpProfileAppliedPayload
    {
        public DevpProfileAppliedPayload()
        {
            DevpProfileAppliedPayloadAttribute = new HashSet<DevpProfileAppliedPayloadAttribute>();
        }

        public int Id { get; set; }
        public int DevpProfileAppliedId { get; set; }
        public string PayloadName { get; set; }
        public string GroupName { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }

        public virtual DevpProfileApplied DevpProfileApplied { get; set; }
        public virtual ICollection<DevpProfileAppliedPayloadAttribute> DevpProfileAppliedPayloadAttribute { get; set; }
    }
}