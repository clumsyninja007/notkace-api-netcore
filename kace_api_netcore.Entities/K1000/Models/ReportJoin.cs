namespace kace_api_netcore.Entities.K1000.Models
{
    public class ReportJoin
    {
        public long Id { get; set; }
        public long BusinessObjectId { get; set; }
        public string Name { get; set; }
        public string JoinExpr { get; set; }
        public byte Grouped { get; set; }
        public string Requires { get; set; }
        public string FilterTables { get; set; }
        public string FilterLink { get; set; }
        public byte IsClassic { get; set; }
        public byte IsSmarty { get; set; }
        public string Version { get; set; }
        public byte IsSystem { get; set; }
        public string InternalDescription { get; set; }
    }
}