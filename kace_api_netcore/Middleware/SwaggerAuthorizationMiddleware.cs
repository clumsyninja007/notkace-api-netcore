using kace_api_netcore.Auth.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace kace_api_netcore.Middleware
{
    /// <summary>
    /// Middleware to protect API Swagger docs
    /// </summary>
    public class SwaggerAuthorizationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IAuthenticationService _authenticationService;
        private readonly ILogger _logger;

        public SwaggerAuthorizationMiddleware(RequestDelegate next, IAuthenticationService authenticationService, ILogger logger)
        {
            _next = next;
            _authenticationService = authenticationService;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var itGroupSid = _authenticationService.GetGroupSid("County IT");

            // If API documentation route and user isn't authenticated or doesn't have the appropriate authorization, then block
            if (context.Request.Path.StartsWithSegments("/swagger")
                && !context.User.Identity.IsAuthenticated ||
                !context.User.HasClaim("http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid", itGroupSid))
            {
                _logger.LogWarning($"API documentation endpoint unauthorized access attempt by [{context.Connection.RemoteIpAddress}]");
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                return;
            }

            await _next.Invoke(context);
        }
    }
}
