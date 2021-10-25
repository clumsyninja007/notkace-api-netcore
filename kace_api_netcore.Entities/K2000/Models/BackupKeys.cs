namespace kace_api_netcore.Entities.K2000.Models
{
    public class BackupKeys
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string KeyName { get; set; }
        public string TableField { get; set; }
        public string TableName { get; set; }
        public long PayloadKey { get; set; }
    }
}