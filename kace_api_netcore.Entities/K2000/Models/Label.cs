using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class Label
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
        public string KaceAltLocation { get; set; }
        public string KaceAltLocationUser { get; set; }
        public string KaceAltLocationPassword { get; set; }
    }
}