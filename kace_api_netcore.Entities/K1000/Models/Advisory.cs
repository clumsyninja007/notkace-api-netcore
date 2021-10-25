using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Advisory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Category { get; set; }
        public string Importance { get; set; }
        public string Platform { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public byte Markdown { get; set; }
        public long PageViews { get; set; }
        public long PageVotes { get; set; }
        public string OldMarkdownNote { get; set; }
    }
}