namespace kace_api_netcore.Entities.K2000.Models
{
    public class DashboardCustomWidgets
    {
        public long Id { get; set; }
        public string WidgetTitle { get; set; }
        public string WidgetSubtitle { get; set; }
        public string WidgetClass { get; set; }
        public long WidgetTypeId { get; set; }
        public string WidgetDatasource { get; set; }
        public string WidgetInfo { get; set; }
        public string WidgetChartlabel { get; set; }
        public string WidgetLinkurl { get; set; }
        public int WidgetWidth { get; set; }
        public int WidgetHeight { get; set; }
        public string WidgetData { get; set; }
        public string WidgetPermissions { get; set; }
        public string WidgetUuid { get; set; }
    }
}