namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonLogConfig
    {
        public long KmonLogConfigId { get; set; }
        public long KmonConfigId { get; set; }
        public string LogPath { get; set; }
        public string LogDateFormat { get; set; }
        public byte? OsType { get; set; }

        public virtual KmonConfig KmonConfig { get; set; }
    }
}