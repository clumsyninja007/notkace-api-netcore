namespace kace_api_netcore.Entities.K1000.Models
{
    public class ReportFieldGroup
    {
        public long Id { get; set; }
        public long BusinessObjectId { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public byte IsClassic { get; set; }
        public byte IsSmarty { get; set; }
        public byte IsAdvancedSearch { get; set; }
        public string Version { get; set; }
        public byte IsSystem { get; set; }
        public string InternalDescription { get; set; }
        public string RequiredFeature { get; set; }
    }
}