using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoWebAppIdentity.Areas.Identity.Data;

//public class : IdentityDbContext<IdentityUser>
public class DemoWebAppIdentityContext : IdentityDbContext<IdentityUser>
{
    public DemoWebAppIdentityContext(DbContextOptions<DemoWebAppIdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
