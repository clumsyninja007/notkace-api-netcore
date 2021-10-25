using System;
using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonConfig
    {
        public KmonConfig()
        {
            KmonCondition = new HashSet<KmonCondition>();
            KmonConfigDetail = new HashSet<KmonConfigDetail>();
            KmonConfigDeviceJt = new HashSet<KmonConfigDeviceJt>();
            KmonLogConfig = new HashSet<KmonLogConfig>();
            KmonMaintConfig = new HashSet<KmonMaintConfig>();
            KmonSnmpConfig = new HashSet<KmonSnmpConfig>();
        }

        public long KmonConfigId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ConfigType { get; set; }
        public byte? IsDefault { get; set; }
        public byte? IsHidden { get; set; }
        public byte? IsLepProfile { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }

        public virtual ICollection<KmonCondition> KmonCondition { get; set; }
        public virtual ICollection<KmonConfigDetail> KmonConfigDetail { get; set; }
        public virtual ICollection<KmonConfigDeviceJt> KmonConfigDeviceJt { get; set; }
        public virtual ICollection<KmonLogConfig> KmonLogConfig { get; set; }
        public virtual ICollection<KmonMaintConfig> KmonMaintConfig { get; set; }
        public virtual ICollection<KmonSnmpConfig> KmonSnmpConfig { get; set; }
    }
}