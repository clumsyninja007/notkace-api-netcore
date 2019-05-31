using System;

namespace notkace_api_netcore.Models
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
        public long? Permissions { get; set; }
        public string LdapUid { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string PagerPhone { get; set; }
        public long? RoleId { get; set; }
        public long? LinkedApplianceId { get; set; }
        public string Path { get; set; }
        public int? Level { get; set; }
        public long? ManagerId { get; set; }
        public long? LocationId { get; set; }
        public long? LocaleBrowserId { get; set; }
        public long? HdDefaultQueueId { get; set; }
        public string HdDefaultView { get; set; }
        public long? ApiEnabled { get; set; }
        public long? SecurityNotifications { get; set; }
        public long? SalesNotifications { get; set; }
        public long? PrimaryDeviceId { get; set; }
        public long? DeviceCount { get; set; }
        public byte IsArchived { get; set; }
        public DateTimeOffset ArchivedDate { get; set; }
        public long ArchivedBy { get; set; }
        public byte? _2faRequired { get; set; }
        public byte? _2faConfigured { get; set; }
        public byte[] _2faSecret { get; set; }
        public DateTimeOffset _2faCutoffDate { get; set; }
        public string Theme { get; set; }
    }
}