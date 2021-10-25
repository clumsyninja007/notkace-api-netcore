using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineChromeosDetails
    {
        public long MachineChromeosDetailsId { get; set; }
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? LastSync { get; set; }
        public DateTimeOffset? SupportEndDate { get; set; }
        public string AnnotatedUser { get; set; }
        public string AnnotatedLocation { get; set; }
        public string Notes { get; set; }
        public string Model { get; set; }
        public string Meid { get; set; }
        public string OrderNumber { get; set; }
        public byte? WillAutoRenew { get; set; }
        public string OsVersion { get; set; }
        public string PlatformVersion { get; set; }
        public string FirmwareVersion { get; set; }
        public string MacAddress { get; set; }
        public string BootMode { get; set; }
        public DateTimeOffset? LastEnrollmentTime { get; set; }
        public string OrgUnitPath { get; set; }

        public virtual Machine IdNavigation { get; set; }
    }
}