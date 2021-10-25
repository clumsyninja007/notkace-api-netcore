namespace kace_api_netcore.Entities.K1000.Models
{
    public class PatchlinkBulletinMachineStatus
    {
        public string BulletinId { get; set; }
        public long PlatformId { get; set; }
        public long MachineId { get; set; }
        public string Status { get; set; }
    }
}