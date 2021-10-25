namespace kace_api_netcore.Entities.K1000.Models
{
    public class KbotVerifySteps
    {
        public long KbotId { get; set; }
        public long VerifyIndex { get; set; }
        public long StepIndex { get; set; }
        public string Section { get; set; }
        public long KbotGrammarId { get; set; }
        public long AttrOrder { get; set; }
        public string AttrValue { get; set; }
    }
}