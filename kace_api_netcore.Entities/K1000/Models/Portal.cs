using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class Portal
    {
        public long Id { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public long? SoftwareId { get; set; }
        public string SamCatalogId { get; set; }
        public long? SamAttachedFileId { get; set; }
        public string Notes { get; set; }
        public long? Enabled { get; set; }
        public long? DisplayCost { get; set; }
        public long? RequiresKey { get; set; }
        public long? EmailUser { get; set; }
        public long? EmailManagement { get; set; }
        public string LicenseText { get; set; }
        public string DocfileName { get; set; }
        public int? DocfileSize { get; set; }
        public string InstallationNotes { get; set; }
        public long? KbotId { get; set; }
        public long? MiId { get; set; }
        public byte RestrictMachine { get; set; }
        public long? LicenseId { get; set; }
        public string VendorLicenseText { get; set; }
        public string ProductKey { get; set; }
        public decimal? UnitCost { get; set; }
        public short ApprovalFrequency { get; set; }
        public long? HdServiceId { get; set; }
    }
}