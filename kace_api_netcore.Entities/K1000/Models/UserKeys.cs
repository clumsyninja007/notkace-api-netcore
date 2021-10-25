using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserKeys
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public long? PkgId { get; set; }
        public string PkgName { get; set; }
        public string PkgVersion { get; set; }
        public string ProductKey { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}