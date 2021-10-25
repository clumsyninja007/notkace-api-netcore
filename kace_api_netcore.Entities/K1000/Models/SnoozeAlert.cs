namespace kace_api_netcore.Entities.K1000.Models
{
    public class SnoozeAlert
    {
        public long Id { get; set; }
        public byte? Enabled { get; set; }
        public string DialogOptions { get; set; }
        public int? DialogTimeout { get; set; }
        public int? SnoozeDuration { get; set; }
        public string Message { get; set; }
        public string DialogTimeoutAction { get; set; }
        public byte LimitSnooze { get; set; }
        public int SnoozeCount { get; set; }
    }
}