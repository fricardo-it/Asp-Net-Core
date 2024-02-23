using DemoWebAppIdentity.Areas.Identity.Data;
using DemoWebAppIdentity.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DemoWebAppIdentity.Configuration
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AllowedToDelete", policy => policy.RequireClaim("AllowedToDelete"));

                // Always exist a Policy Requirement, it is necessary implements a Handler.
                options.AddPolicy("AllowedToWrite", policy => policy.Requirements.Add(new RequiredPermission("AllowedToWrite")));
            });
            return services;
        }

        public static IServiceCollection AddIdentityConfig(this IServiceCollection services, IConfiguration configuration)
        {
            // LGPD Cookies Policies
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Adding Identity context supporting by EF
            services.AddDbContext<DemoWebAppIdentityContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DemoWebAppIdentityConnection")));

            // Adding default Identity configuration
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<DemoWebAppIdentityContext>();

            return services;
        }
    }
}
