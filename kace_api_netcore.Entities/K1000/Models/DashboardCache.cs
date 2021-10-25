using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class DashboardCache
    {
        public long DashboardCacheId { get; set; }
        public long UserId { get; set; }
        public long LocaleBrowserId { get; set; }
        public DateTimeOffset? DatasourceLastTime { get; set; }
        public string DatasourceLastResult { get; set; }
        public long DatasourceId { get; set; }
    }
}