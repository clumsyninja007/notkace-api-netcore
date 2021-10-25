namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkPatchCount
    {
        public string Patchuid { get; set; }
        public long Patched { get; set; }
        public long Unpatched { get; set; }
        public long Error { get; set; }
        public long Compliance { get; set; }
    }
}