namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkScheduleRunCounts
    {
        public long Id { get; set; }
        public long PatchlinkScheduleId { get; set; }
        public long PatchlinkScheduleRunId { get; set; }
        public long Pending { get; set; }
        public long Downloading { get; set; }
        public long Executing { get; set; }
        public long Rebooting { get; set; }
        public long Paused { get; set; }
        public long Succeeded { get; set; }
        public long Failed { get; set; }
        public long Completed { get; set; }
        public long Offline { get; set; }
    }
}