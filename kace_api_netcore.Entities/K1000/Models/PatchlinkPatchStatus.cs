namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkPatchStatus
    {
        public string Patchuid { get; set; }
        public int? Status { get; set; }
        public string Notes { get; set; }
        public int TargetAllMachines { get; set; }
        public byte IsSuperceded { get; set; }
    }
}