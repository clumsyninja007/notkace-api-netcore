namespace kace_api_netcore.Entities.K2000.Models
{
    public class KboxVersion
    {
        public long Id { get; set; }
        public long Major { get; set; }
        public long Minor { get; set; }
        public long Build { get; set; }
        public string Package { get; set; }
        public string Description { get; set; }
        public long UiOrder { get; set; }
    }
}