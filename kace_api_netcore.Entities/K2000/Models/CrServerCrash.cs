using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class CrServerCrash
    {
        public long Id { get; set; }
        public DateTime CrashTime { get; set; }
        public DateTime? UploadedAt { get; set; }
        public string Type { get; set; }
        public string Filename { get; set; }
        public long? LineNumber { get; set; }
        public string ExceptionText { get; set; }
        public string ServerPath { get; set; }
        public string QueryString { get; set; }
        public string ScriptFilename { get; set; }
    }
}