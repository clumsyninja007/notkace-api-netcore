namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScapRule
    {
        public long Id { get; set; }
        public long ScapProfileId { get; set; }
        public long ScapGroupId { get; set; }
        public string Identifier { get; set; }
        public int Seq { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RawXml { get; set; }
    }
}