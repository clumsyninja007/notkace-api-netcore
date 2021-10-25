namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScapResultScore
    {
        public long ScapResultId { get; set; }
        public string System { get; set; }
        public decimal ScoreMaximum { get; set; }
        public decimal ScoreValue { get; set; }
    }
}