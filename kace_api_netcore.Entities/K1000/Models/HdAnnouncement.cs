using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdAnnouncement
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public byte IsHidden { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long Ordinal { get; set; }
        public byte IsUrgent { get; set; }
    }
}