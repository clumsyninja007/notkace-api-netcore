namespace kace_api_netcore.Entities.K1000.Models
{
    public class ScapRuleIdent
    {
        public long Id { get; set; }
        public long ScapRuleId { get; set; }
        public long ScapProfileId { get; set; }
        public string IdentSystem { get; set; }
        public string IdentValue { get; set; }
    }
}