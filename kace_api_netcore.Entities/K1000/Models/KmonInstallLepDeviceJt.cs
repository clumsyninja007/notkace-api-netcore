namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonInstallLepDeviceJt
    {
        public long KmonLepInstallId { get; set; }
        public long KmonLepId { get; set; }
        public long KmonMonitoredDeviceId { get; set; }

        public virtual KmonLep KmonLep { get; set; }
        public virtual KmonLepInstall KmonLepInstall { get; set; }
        public virtual KmonMonitoredDevice KmonMonitoredDevice { get; set; }
    }
}