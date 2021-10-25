using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class Journal
    {
        public long Id { get; set; }
        public string Filename { get; set; }
        public string DbSchema { get; set; }
        public DateTimeOffset Ran { get; set; }
        public string Status { get; set; }
    }
}