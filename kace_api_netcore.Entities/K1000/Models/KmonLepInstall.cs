using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonLepInstall
    {
        public KmonLepInstall()
        {
            KmonInstallLepDeviceJt = new HashSet<KmonInstallLepDeviceJt>();
        }

        public long KmonLepInstallId { get; set; }
        public byte? AutoAddProfile { get; set; }
        public byte? OverwriteWinLep { get; set; }
        public byte? OverwriteNonWinLep { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual ICollection<KmonInstallLepDeviceJt> KmonInstallLepDeviceJt { get; set; }
    }
}