using kace_api_netcore.Auth.Extensions;
using kace_api_netcore.Auth.Interfaces;
using System;
using System.DirectoryServices.AccountManagement;

namespace kace_api_netcore.Auth
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Library is specifically for Windows Auth")]
    public class AuthenticationService : IAuthenticationService
    {
        private readonly PrincipalContext _context;

        public AuthenticationService()
        {
            _context = new PrincipalContext(ContextType.Domain, "ALL", "OU=Employees,DC=example,DC=com");
        }

        private static CountyUser GetUserBySamAccountName(PrincipalContext context, string username)
        {
            return CountyUser.FindByIdentity(context, IdentityType.SamAccountName, username);
        }

        private static CountyUser GetUserByEmployeeId(PrincipalContext context, string id)
        {
            var userSearch = new CountyUser(context)
            {
                EmployeeId = id
            };
            var searcher = new PrincipalSearcher(userSearch);

            return searcher.FindOne() as CountyUser;
        }

        public string GetDepartmentByUsername(string username)
        {
            var user = GetUserBySamAccountName(_context, username);

            if (user == null)
            {
                throw new ArgumentException($"User {username} not found");
            }

            return user.Department;
        }

        public string GetUsernameByEmployeeId(string id)
        {
            var user = GetUserByEmployeeId(_context, id);

            if (user == null)
            {
                throw new ArgumentException($"User with ID {id} not found");
            }

            return user.SamAccountName;
        }

        public string GetGroupSid(string groupname)
        {
            var group = GroupPrincipal.FindByIdentity(_context, groupname);

            return group?.Sid.Value;
        }
    }
}
