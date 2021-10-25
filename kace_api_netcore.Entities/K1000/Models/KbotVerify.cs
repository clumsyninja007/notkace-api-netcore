namespace kace_api_netcore.Entities.K1000.Models
{
    public class KbotVerify
    {
        public long KbotId { get; set; }
        public long VerifyIndex { get; set; }
        public string FailureMode { get; set; }
        public int Attempts { get; set; }
    }
}