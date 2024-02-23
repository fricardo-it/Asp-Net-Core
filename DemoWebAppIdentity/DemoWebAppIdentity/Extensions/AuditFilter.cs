using KissLog;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoWebAppIdentity.Extensions
{
    public class AuditFilter : IActionFilter
    {
        private readonly IKLogger _logger;

        public AuditFilter(IKLogger logger)
        {
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context) {}

        public void OnActionExecuting(ActionExecutingContext context)
        {

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                var message = context.HttpContext.User.Identity.Name + " Access: " +
                              context.HttpContext.Request.GetDisplayUrl();
                _logger.Info(message);
            }
        }
    }
}
