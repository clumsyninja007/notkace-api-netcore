namespace kace_api_netcore.Entities.K1000.Models
{
    public class OvalStatus
    {
        public long Id { get; set; }
        public long MachineId { get; set; }
        public long OvalDefinitionId { get; set; }
        public string Result { get; set; }
    }
}