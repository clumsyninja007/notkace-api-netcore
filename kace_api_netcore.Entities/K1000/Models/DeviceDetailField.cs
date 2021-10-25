namespace kace_api_netcore.Entities.K1000.Models
{
    public class DeviceDetailField
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int IsManual { get; set; }
        public int Sequence { get; set; }
        public long DeviceDetailSectionId { get; set; }
        public string RequiredFeature { get; set; }
    }
}