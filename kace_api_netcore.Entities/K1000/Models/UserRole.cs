using System;

namespace kace_api_netcore.Entities.K1000.Models
{
    public class UserRole
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string Description { get; set; }
        public long SystemRoleId { get; set; }
        public byte ScopeAllMachines { get; set; }
    }
}