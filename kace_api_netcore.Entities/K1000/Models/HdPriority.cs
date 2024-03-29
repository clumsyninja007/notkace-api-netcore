﻿using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdPriority
    {
        public long Id { get; set; }
        public long HdQueueId { get; set; }
        public string Name { get; set; }
        public long Ordinal { get; set; }
        public string Color { get; set; }
        public long? EscalationMinutes { get; set; }
        public byte? UseBusinessHoursForEscalation { get; set; }
        public byte? IsSlaEnabled { get; set; }
        public long? ResolutionDueDateMinutes { get; set; }
        public byte? UseBusinessHoursForSla { get; set; }
        public long? SlaNotificationRecurrenceMinutes { get; set; }

        public virtual ICollection<HdTicket> HdTickets { get; set; }
    }
}