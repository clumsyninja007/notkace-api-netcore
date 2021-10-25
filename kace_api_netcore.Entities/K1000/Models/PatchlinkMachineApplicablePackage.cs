namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkMachineApplicablePackage
    {
        public long MachineId { get; set; }
        public string Patchuid { get; set; }
        public string ApplicablePackage { get; set; }
        public string ApplicablePackagePath { get; set; }
        public string DeployStatus { get; set; }
        public long DeployErrorCode { get; set; }
        public long DeployRcode { get; set; }
        public string DeployRdesc { get; set; }
        public string RollbackStatus { get; set; }
        public long RollbackErrorCode { get; set; }
        public long RollbackRcode { get; set; }
        public string RollbackRdesc { get; set; }
    }
}