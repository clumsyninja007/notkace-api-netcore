namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonSnmpConfig
    {
        public long KmonSnmpConfigId { get; set; }
        public long KmonConfigId { get; set; }
        public string AlertFormat { get; set; }
        public byte AutoAddAll { get; set; }

        public virtual KmonConfig KmonConfig { get; set; }
    }
}