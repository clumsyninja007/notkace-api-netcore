using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineMobile
    {
        public long MachineMobileId { get; set; }
        public long? Id { get; set; }
        public string Udid { get; set; }
        public string DeviceType { get; set; }
        public string ModemFirmware { get; set; }
        public string Iccid { get; set; }
        public string Imei { get; set; }
        public string Meid { get; set; }
        public string PhoneNumber { get; set; }
        public string Carrier { get; set; }
        public string CurrentCarrierNetwork { get; set; }
        public string BatteryLevel { get; set; }
        public DateTimeOffset? LastCheckIn { get; set; }
        public byte? IsEnrolled { get; set; }
        public byte? IsCompliant { get; set; }
        public byte? IsEncrypted { get; set; }
        public byte? IsRooted { get; set; }
        public byte? IsSupervised { get; set; }
        public byte? IsLost { get; set; }
        public byte? ActivationLockEnabled { get; set; }
        public byte? LocatorServiceEnabled { get; set; }
        public byte? VoiceRoamingEnabled { get; set; }
        public byte? DataRoamingEnabled { get; set; }

        public virtual Machine IdNavigation { get; set; }
    }
}