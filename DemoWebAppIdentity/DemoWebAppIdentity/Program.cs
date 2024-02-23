using DemoWebAppIdentity.Configuration;
using DemoWebAppIdentity.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();


if (builder.Environment.IsProduction())
{
    builder.Configuration.AddUserSecrets<Program>();
}

// *** Configuring services in the Container ***

builder.Services.AddIdentityConfig(builder.Configuration);
builder.Services.AddAuthorizationConfig();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
builder.Services.ResolveDependencies();

builder.Services.RegisterKissLogListeners();

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(typeof(AuditFilter));
});
builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error/500");
    app.UseStatusCodePagesWithRedirects("/error/{0}");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.RegisterKissLogListeners(builder.Configuration);

app.Run();


//// Install-Package Microsoft.AspNetCore.Identity.UI
//// add-migration "NAME"
//// update-database
////
//// test@test.com  |  AV_g:gUY_S5GDuE
//// Install-Package KissLog.AspNetCore