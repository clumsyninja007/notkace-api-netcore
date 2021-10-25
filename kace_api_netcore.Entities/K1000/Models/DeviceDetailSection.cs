namespace kace_api_netcore.Entities.K1000.Models
{
    public class DeviceDetailSection
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public long GroupId { get; set; }
        public long Sequence { get; set; }
        public string RequiredFeature { get; set; }
    }
}