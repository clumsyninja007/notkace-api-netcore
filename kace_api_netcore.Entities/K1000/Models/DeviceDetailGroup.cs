namespace kace_api_netcore.Entities.K1000.Models
{
    public class DeviceDetailGroup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string TemplateName { get; set; }
        public long Sequence { get; set; }
        public int HideLabelText { get; set; }
        public string RequiredFeature { get; set; }
    }
}