namespace kace_api_netcore.Entities.K1000.Models
{
    public class ReplicationShare
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public long LabelId { get; set; }
        public string DestinationDir { get; set; }
        public string Notes { get; set; }
        public byte Enabled { get; set; }
        public string DownloadDir { get; set; }
        public long? CredentialIdDestination { get; set; }
        public byte? IsUnc { get; set; }
        public long? CredentialIdDownload { get; set; }
        public long ErrorCodeForHalt { get; set; }
        public long MaximumBandwidth { get; set; }
        public long RestrictedBandwidth { get; set; }
        public byte InventoryRequested { get; set; }
        public byte FailoverToKbox { get; set; }
        public byte ReplicateAppPatches { get; set; }
        public byte ReplicateAllLstFiles { get; set; }
        public byte DoRepl1 { get; set; }
        public byte ReplicateDellPackages { get; set; }
        public byte RestartTaskAutomatically { get; set; }
        public long TodoFiles { get; set; }
        public long TodoBytes { get; set; }
    }
}