using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonLep
    {
        public KmonLep()
        {
            KmonInstallLepDeviceJt = new HashSet<KmonInstallLepDeviceJt>();
        }

        public long KmonLepId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileLocation { get; set; }
        public long? ItnFileId { get; set; }
        public int? ItnFileTypeId { get; set; }

        public virtual ICollection<KmonInstallLepDeviceJt> KmonInstallLepDeviceJt { get; set; }
    }
}