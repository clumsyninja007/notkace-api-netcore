namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonConfigDeviceJt
    {
        public long KmonMonitoredDeviceId { get; set; }
        public long KmonConfigId { get; set; }

        public virtual KmonConfig KmonConfig { get; set; }
        public virtual KmonMonitoredDevice KmonMonitoredDevice { get; set; }
    }
}