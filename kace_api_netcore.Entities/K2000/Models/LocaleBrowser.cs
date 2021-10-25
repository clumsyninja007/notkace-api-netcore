namespace kace_api_netcore.Entities.K2000.Models
{
    public class LocaleBrowser
    {
        public long Id { get; set; }
        public long MessagesLocaleId { get; set; }
        public long LocaleCollationRuleId { get; set; }
        public long LocaleTimeFormatId { get; set; }
        public string SearchCriteria { get; set; }
        public string LocaleName { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public long SortOrder { get; set; }
        public byte Active { get; set; }
        public byte Konfig { get; set; }
        public int KonfigSortOrder { get; set; }
    }
}