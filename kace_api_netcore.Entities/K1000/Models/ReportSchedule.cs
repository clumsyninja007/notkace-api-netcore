using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class ReportSchedule
    {
        public long Id { get; set; }
        public long ImCronId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? NextRun { get; set; }
        public string Subject { get; set; }
        public long? ReportId { get; set; }
        public string FileType { get; set; }
        public string CcList { get; set; }
        public string User { get; set; }
        public byte? SendWhenResult { get; set; }
        public byte SmartyReport { get; set; }
        public string Locale { get; set; }
        public long? AttachmentType { get; set; }
        public byte? ReportType { get; set; }
        public byte? UseTimeZones { get; set; }
    }
}