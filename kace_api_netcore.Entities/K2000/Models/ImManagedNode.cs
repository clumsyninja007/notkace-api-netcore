using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class ImManagedNode
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Ip { get; set; }
    }
}