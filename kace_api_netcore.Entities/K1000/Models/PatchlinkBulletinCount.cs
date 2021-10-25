namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkBulletinCount
    {
        public string BulletinId { get; set; }
        public long PlatformId { get; set; }
        public long CacheSize { get; set; }
        public long Patched { get; set; }
        public long Unpatched { get; set; }
        public long Error { get; set; }
        public long Compliance { get; set; }
        public long PatchesTotal { get; set; }
        public long PatchesActive { get; set; }
        public long PatchesDisabled { get; set; }
        public long PatchesInactive { get; set; }
        public long PatchesApplicable { get; set; }
        public long PatchesSuperceded { get; set; }
    }
}