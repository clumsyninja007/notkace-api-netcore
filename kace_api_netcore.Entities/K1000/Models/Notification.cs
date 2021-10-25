using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Notification
    {
        public Notification()
        {
            NotificationUserJt = new HashSet<NotificationUserJt>();
        }

        public long Id { get; set; }
        public string Query { get; set; }
        public long? Type { get; set; }
        public string Title { get; set; }
        public string Recipient { get; set; }
        public string Notes { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset NextRun { get; set; }
        public int Frequency { get; set; }
        public byte Enabled { get; set; }
        public byte PushEnabled { get; set; }
        public string Locale { get; set; }
        public string FfJson { get; set; }
        public byte IsAdvancedSearch { get; set; }
        public long ScopeUserRoleId { get; set; }

        public virtual ICollection<NotificationUserJt> NotificationUserJt { get; set; }
    }
}