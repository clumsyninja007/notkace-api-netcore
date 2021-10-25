using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdTicketRule
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public int? Type { get; set; }
        public DateTimeOffset NextRun { get; set; }
        public int Frequency { get; set; }
        public byte Enabled { get; set; }
        public int Ordinal { get; set; }
        public long HdQueueId { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public string SelectQuery { get; set; }
        public string UpdateQuery { get; set; }
        public string SerializedQueryData { get; set; }
        public string Recipient { get; set; }
        public string EmailSubject { get; set; }
        public string EmailToAttribute { get; set; }
        public string EmailBody { get; set; }
        public string TicketComment { get; set; }
        public byte TicketCommentOwnersOnly { get; set; }
        public string LastRunLog { get; set; }
        public string SystemRule { get; set; }
        public string SystemRuleParms { get; set; }
    }
}