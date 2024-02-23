using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor;

namespace DemoWebAppIdentity.Extensions;

public static class RazorExtensions
{
    public static bool IfClaim(this RazorPage page, string claimName, string claimValue)
    {
        return CustomAuthorization.UserClaimsValidate(page.Context, claimName, claimValue);
    }

    public static string IfClaimShow(this RazorPage page, string claimName, string claimValue)
    {
        return CustomAuthorization.UserClaimsValidate(page.Context, claimName, claimValue) ? "" : "disabled";
    }

    public static IHtmlContent IfClaimShow(this IHtmlContent page, HttpContext context, string claimName, string claimValue)
    {
        return CustomAuthorization.UserClaimsValidate(context, claimName, claimValue) ? page : null;
    }

}