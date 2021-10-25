namespace kace_api_netcore.Entities.K1000.Models
{
    public class HdHomePageWidget
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string WidgetType { get; set; }
        public string TemplateName { get; set; }
        public long Ordinal { get; set; }
        public byte Visible { get; set; }
        public string DataSource { get; set; }
        public string RequiredFeature { get; set; }
    }
}