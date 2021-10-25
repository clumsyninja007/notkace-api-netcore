namespace kace_api_netcore.Entities.K1000.Models
{
    public class MachineSnmpData
    {
        public long MachineSnmpDataId { get; set; }
        public long MachineId { get; set; }
        public string FullWalk { get; set; }

        public virtual Machine Machine { get; set; }
    }
}