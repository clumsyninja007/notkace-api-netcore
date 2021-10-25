using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string BudgetCode { get; set; }
        public string Domain { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset LdapImported { get; set; }
        public string Location { get; set; }
        public long? Permissions { get; set; }
        public string Theme { get; set; }
    }
}