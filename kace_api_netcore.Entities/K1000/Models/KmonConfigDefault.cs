namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonConfigDefault
    {
        public long KmonConfigDefaultId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ConfigType { get; set; }
        public byte? OsType { get; set; }
        public string LogPath { get; set; }
        public string LogDateFormat { get; set; }
        public string AlertFormat { get; set; }
        public string SerializedCondition { get; set; }
    }
}