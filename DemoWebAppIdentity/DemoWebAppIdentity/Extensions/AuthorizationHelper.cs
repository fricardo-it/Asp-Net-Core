using Microsoft.AspNetCore.Authorization;

namespace DemoWebAppIdentity.Extensions
{
    public class RequiredPermission : IAuthorizationRequirement
    {
        public string Permission { get; }

        public RequiredPermission(string permission)
        {
            Permission = permission;
        }
    }

    // Always exist a Policy Requirement, it is necessary implements a Handler.
    // This handler personalizes claim polices.
    public class RequiredPermissionHandler : AuthorizationHandler<RequiredPermission>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RequiredPermission requirement)
        {
            if (context.User.HasClaim(c => c.Type == "Permission" && c.Value.Contains(requirement.Permission)))
            {
                context.Succeed(requirement);
                
            }
            return Task.CompletedTask;
        }
    }
}
