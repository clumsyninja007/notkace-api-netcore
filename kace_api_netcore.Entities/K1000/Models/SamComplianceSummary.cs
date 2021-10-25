namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamComplianceSummary
    {
        public long Id { get; set; }
        public string SummaryType { get; set; }
        public string ProductName { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
        public long InstallCount { get; set; }
        public long LicenseCount { get; set; }
        public long Variance { get; set; }
        public byte MeteringEnabled { get; set; }
        public long? MeteredCount { get; set; }
        public long? Usage30 { get; set; }
        public long? Usage60 { get; set; }
        public long? Usage90 { get; set; }
        public long? NotUsed30 { get; set; }
        public long? NotUsed60 { get; set; }
        public long? NotUsed90 { get; set; }
        public byte MultiplePublishers { get; set; }
        public byte IsSuite { get; set; }
        public byte NegativeChildVariance { get; set; }
        public decimal? Risk { get; set; }
        public decimal? Surplus { get; set; }
    }
}