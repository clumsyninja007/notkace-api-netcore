namespace kace_api_netcore.Auth.Interfaces
{
    public interface IAuthenticationService
    {
        string GetDepartmentByUsername(string username);
        string GetUsernameByEmployeeId(string id);
        string GetGroupSid(string groupname);
    }
}
