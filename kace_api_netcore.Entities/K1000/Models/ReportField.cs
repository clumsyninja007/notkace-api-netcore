namespace kace_api_netcore.Entities.K1000.Models
{
    public class ReportField
    {
        public long Id { get; set; }
        public long BusinessObjectId { get; set; }
        public string Label { get; set; }
        public string SelectExpr { get; set; }
        public string SortExpr { get; set; }
        public string Fieldname { get; set; }
        public string JoinName { get; set; }
        public string Description { get; set; }
        public int GroupSequence { get; set; }
        public string Alias { get; set; }
        public string FieldType { get; set; }
        public byte IsClassic { get; set; }
        public byte IsSmarty { get; set; }
        public byte IsAdvancedSearch { get; set; }
        public byte HideField { get; set; }
        public byte HideWhere { get; set; }
        public byte AlwaysSubquery { get; set; }
        public string Version { get; set; }
        public byte IsSystem { get; set; }
        public string InternalDescription { get; set; }
        public byte? CalculatedField { get; set; }
        public string RequiredFeature { get; set; }
    }
}