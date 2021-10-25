using System.Collections.Generic;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class KmonCondition
    {
        public KmonCondition()
        {
            KmonAlert = new HashSet<KmonAlert>();
        }

        public long KmonConditionId { get; set; }
        public long KmonConfigId { get; set; }
        public string Severity { get; set; }
        public string Criteria { get; set; }
        public string ExcludeCriteria { get; set; }
        public byte? IsCaseSensitive { get; set; }
        public long Ordinal { get; set; }
        public long? QueueId { get; set; }

        public virtual KmonConfig KmonConfig { get; set; }
        public virtual ICollection<KmonAlert> KmonAlert { get; set; }
    }
}