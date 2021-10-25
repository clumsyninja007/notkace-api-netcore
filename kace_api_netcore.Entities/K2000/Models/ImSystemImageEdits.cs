namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImSystemImageEdits
    {
        public long Id { get; set; }
        public long ImDeploymentId { get; set; }
        public long UserId { get; set; }
        public string CommandType { get; set; }
        public string SourcePath { get; set; }
        public string DestPath { get; set; }
    }
}