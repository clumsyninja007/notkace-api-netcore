namespace kace_api_netcore.Entities.K1000.Models
{
    public class SamComplianceDetail
    {
        public long Id { get; set; }
        public long SamComplianceSummaryProductId { get; set; }
        public long SamComplianceSummaryEditionId { get; set; }
        public string SamCatalogId { get; set; }
        public long InstallCount { get; set; }
        public long LicenseCount { get; set; }
        public long Variance { get; set; }
        public string LicenseCoverage { get; set; }
        public byte MeteringEnabled { get; set; }
        public long? MeteredCount { get; set; }
        public long? Usage30 { get; set; }
        public long? Usage60 { get; set; }
        public long? Usage90 { get; set; }
        public long? NotUsed30 { get; set; }
        public long? NotUsed60 { get; set; }
        public long? NotUsed90 { get; set; }
        public decimal? Risk { get; set; }
        public decimal? Surplus { get; set; }
    }
}