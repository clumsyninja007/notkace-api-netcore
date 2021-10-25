namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonConfigDetail
    {
        public long KmonConfigDetailId { get; set; }
        public long KmonMonitoredDeviceId { get; set; }
        public long KmonConfigId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual KmonConfig KmonConfig { get; set; }
        public virtual KmonMonitoredDevice KmonMonitoredDevice { get; set; }
    }
}