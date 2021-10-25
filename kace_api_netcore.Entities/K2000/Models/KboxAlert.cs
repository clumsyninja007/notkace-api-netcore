using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class KboxAlert
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Type { get; set; }
        public string Tag { get; set; }
        public int Priority { get; set; }
        public string Message { get; set; }
    }
}