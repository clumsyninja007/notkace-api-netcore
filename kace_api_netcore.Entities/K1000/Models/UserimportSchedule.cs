using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserimportSchedule
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
        public string CcList { get; set; }
        public string User { get; set; }
        public long? AuthServerId { get; set; }
        public string Attrib { get; set; }
        public string LabelAttrib { get; set; }
        public string LabelPrefix { get; set; }
        public string BinAttrib { get; set; }
        public long? RowLimit { get; set; }
        public string ImportLabels { get; set; }
        public string Mapping { get; set; }
        public long ImportRoleId { get; set; }
    }
}