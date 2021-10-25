namespace kace_api_netcore.Entities.K2000.Models
{
    public class DashboardDatasources
    {
        public long Id { get; set; }
        public string DatasourceName { get; set; }
        public string DatasourceQueryType { get; set; }
        public string DatasourceQueryData { get; set; }
        public int DatasourceLifeMinutes { get; set; }
        public int? DatasourceCachehits { get; set; }
        public string DatasourceDataType { get; set; }
        public string DatasourceDemoResult { get; set; }
        public string RequiredFeature { get; set; }
    }
}