namespace kace_api_netcore.Entities.K2000.Models
{
    public class GridColumnsOverrides
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Page { get; set; }
        public string ColumnsDef { get; set; }
        public int? DisplayLength { get; set; }
        public byte? CompactView { get; set; }
    }
}