using System.DirectoryServices.AccountManagement;

namespace kace_api_netcore.Auth.Extensions
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Library is specifically for Windows Auth")]
    [DirectoryRdnPrefix("CN")]
    [DirectoryObjectClass("User")]
    public class CountyUser : UserPrincipal
    {
        public CountyUser(PrincipalContext context) : base(context)
        {
        }

        [DirectoryProperty("department")]
        public string Department
        {
            get
            {
                if (ExtensionGet("department").Length != 1)
                {
                    return null;
                }

                return ExtensionGet("department")[0] as string;
            }
        }

        public new static CountyUser FindByIdentity(PrincipalContext context, string identityValue)
        {
            return FindByIdentityWithType(context, typeof(CountyUser), identityValue) as CountyUser;
        }

        public new static CountyUser FindByIdentity(PrincipalContext context,
            IdentityType identityType, string identityValue)
        {
            return FindByIdentityWithType(context, typeof(CountyUser), identityType, identityValue) as CountyUser;
        }
    }
}
