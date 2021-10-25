using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdArchiveTicketChange
    {
        public long Id { get; set; }
        public long? HdTicketId { get; set; }
        public DateTime Timestamp { get; set; }
        public long UserId { get; set; }
        public string Comment { get; set; }
        public string CommentLoc { get; set; }
        public string Description { get; set; }
        public string OwnersOnlyDescription { get; set; }
        public string LocalizedDescription { get; set; }
        public string LocalizedOwnersOnlyDescription { get; set; }
        public byte Mailed { get; set; }
        public DateTime? MailedTimestamp { get; set; }
        public int MailerSession { get; set; }
        public string NotifyUsers { get; set; }
        public string ViaEmail { get; set; }
        public byte OwnersOnly { get; set; }
        public byte ResolutionChanged { get; set; }
        public byte SystemComment { get; set; }
        public byte TicketDataChange { get; set; }
    }
}