using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonMonitoredDevice
    {
        public KmonMonitoredDevice()
        {
            KmonAlert = new HashSet<KmonAlert>();
            KmonConfigDetail = new HashSet<KmonConfigDetail>();
            KmonConfigDeviceJt = new HashSet<KmonConfigDeviceJt>();
            KmonInstallLepDeviceJt = new HashSet<KmonInstallLepDeviceJt>();
        }

        public long KmonMonitoredDeviceId { get; set; }
        public long DeviceId { get; set; }
        public byte? Enabled { get; set; }
        public byte? ConfigAlertEnabled { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }

        public virtual ICollection<KmonAlert> KmonAlert { get; set; }
        public virtual ICollection<KmonConfigDetail> KmonConfigDetail { get; set; }
        public virtual ICollection<KmonConfigDeviceJt> KmonConfigDeviceJt { get; set; }
        public virtual ICollection<KmonInstallLepDeviceJt> KmonInstallLepDeviceJt { get; set; }
    }
}