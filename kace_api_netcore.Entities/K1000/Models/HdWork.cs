using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdWork
    {
        public long Id { get; set; }
        public long? HdTicketId { get; set; }
        public long? UserId { get; set; }
        public DateTimeOffset Modified { get; set; }
        public string Note { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public long? VoidedBy { get; set; }
        public float AdjustmentHours { get; set; }

        public virtual HdTicket HdTicket { get; set; }
    }
}