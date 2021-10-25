namespace kace_api_netcore.Entities.K2000.Models
{
    public class DashboardWidgetTypes
    {
        public long Id { get; set; }
        public string WidgetType { get; set; }
        public string WidgetDefUrl { get; set; }
        public string WidgetClass { get; set; }
        public string WidgetThumbUrl { get; set; }
        public string WidgetThumbInactiveUrl { get; set; }
    }
}