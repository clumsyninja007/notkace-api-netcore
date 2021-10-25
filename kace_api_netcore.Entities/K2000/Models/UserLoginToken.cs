using System;

namespace kace_api_netcore.Entities.K2000.Models
{
    public class UserLoginToken
    {
        public long UserId { get; set; }
        public string Token { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}