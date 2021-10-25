namespace kace_api_netcore.Entities.K1000.Models
{
    public class DellPkgStatus
    {
        public long DellPkgId { get; set; }
        public int? Status { get; set; }
        public string Notes { get; set; }
        public int TargetAllMachines { get; set; }
    }
}