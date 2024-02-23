using DemoWebAppIdentity.Extensions;
using KissLog;
using Microsoft.AspNetCore.Authorization;

namespace DemoWebAppIdentity.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            // necessary to implement Handler Interpreter 
            services.AddSingleton<IAuthorizationHandler, RequiredPermissionHandler>();

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
            //services.AddScoped(context => Logger.Factory.Get());

            services.AddScoped<IKLogger>(provider => Logger.Factory.Get());

            services.AddScoped<AuditFilter>();

            return services;
        }
    }
}