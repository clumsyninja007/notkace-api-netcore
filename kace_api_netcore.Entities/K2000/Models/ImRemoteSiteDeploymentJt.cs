namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImRemoteSiteDeploymentJt
    {
        public long ImRemoteSiteId { get; set; }
        public long ImDeploymentId { get; set; }
        public byte DefaultBoot { get; set; }
        public long Version { get; set; }
    }
}