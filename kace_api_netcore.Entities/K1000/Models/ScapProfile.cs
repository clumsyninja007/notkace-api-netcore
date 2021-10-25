namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScapProfile
    {
        public long Id { get; set; }
        public long ScapBenchmarkId { get; set; }
        public int? OvalSteps { get; set; }
        public string Identifier { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}