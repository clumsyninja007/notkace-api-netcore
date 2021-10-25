namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImInstallationSourceRepos
    {
        public long Id { get; set; }
        public string RepoUrl { get; set; }
        public byte Default { get; set; }
        public long? ImInstallationSourceId { get; set; }
    }
}