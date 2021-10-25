namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineIntelAmt
    {
        public long Id { get; set; }
        public string Version { get; set; }
        public string ControlMode { get; set; }
        public string State { get; set; }
        public string FwVersion { get; set; }
        public string Sku { get; set; }
        public string ConfigurationMode { get; set; }
        public string MeiVersion { get; set; }
        public byte IsAmtSupported { get; set; }
        public byte IsAmtEnabledInBios { get; set; }
        public byte IsAmtConfigured { get; set; }
        public byte IsMeiEnabled { get; set; }
    }
}