namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineDcmAmtSettings
    {
        public long Id { get; set; }
        public byte IsAmtSupported { get; set; }
        public byte IsIderEnabled { get; set; }
        public byte IsSolEnabled { get; set; }
    }
}