namespace kace_api_netcore.Entities.K1000.Models
{
    public class ReportObject
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tablename { get; set; }
        public string Where { get; set; }
        public string RequiredJoins { get; set; }
        public string GroupbyColumn { get; set; }
        public string SubsystemName { get; set; }
        public long SubsystemId { get; set; }
        public byte IsClassic { get; set; }
        public byte IsSmarty { get; set; }
        public string LinkTemplate { get; set; }
        public byte SubtopicOnly { get; set; }
        public byte IsAdvancedSearch { get; set; }
        public string IdHint { get; set; }
        public string Version { get; set; }
        public byte IsSystem { get; set; }
        public string InternalDescription { get; set; }
        public byte IsReporting { get; set; }
        public string RequiredFeature { get; set; }
    }
}