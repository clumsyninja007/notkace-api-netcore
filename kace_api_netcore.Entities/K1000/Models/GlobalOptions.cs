using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class GlobalOptions
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string EmailSuffix { get; set; }
        public string AdminEmail { get; set; }
        public decimal ClientFrequency { get; set; }
        public long InventoryFrequency { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public int? HourBegin { get; set; }
        public int? HourEnd { get; set; }
        public string SplashText { get; set; }
        public long KbotUpdateInterval { get; set; }
        public long KbotPingInterval { get; set; }
        public short ShowFailed { get; set; }
        public byte MiaDeleteEnable { get; set; }
        public short MiaDeleteInterval { get; set; }
        public string IgnoreClientIpList { get; set; }
        public short KbotLogHandling { get; set; }
        public byte SambaEnable { get; set; }
        public byte[] SambaPasswordEnc { get; set; }
    }
}