using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Software
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public string DisplayName { get; set; }
        public string Notes { get; set; }
        public string Publisher { get; set; }
        public string Version { get; set; }
        public string Contact { get; set; }
        public string Comments { get; set; }
        public string HelpLink { get; set; }
        public string InstallDate { get; set; }
        public string HelpTelephone { get; set; }
        public string Readme { get; set; }
        public string UninstallString { get; set; }
        public string QuietUninstallString { get; set; }
        public string UrlinfoAbout { get; set; }
        public string FileName { get; set; }
        public long? FileSize { get; set; }
        public string Checksum { get; set; }
        public string InventoryRule { get; set; }
        public string DisplayVersion { get; set; }
        public long? RuleFlag { get; set; }
        public long? RuleDataType { get; set; }
        public byte IsPatch { get; set; }
        public string CustomFieldValue0 { get; set; }
        public string CustomFieldValue1 { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string CustomFieldValue3 { get; set; }
        public string CustomFieldValue4 { get; set; }
        public string CustomFieldValue5 { get; set; }
        public string Category { get; set; }
        public short? Threat { get; set; }
        public byte IsManual { get; set; }
        public byte DontReplicate { get; set; }
    }
}