using DevIO.UI.AppModel.Data;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

// Builder principal � dele de onde tudo deriva
var builder = WebApplication.CreateBuilder(args);

builder.Configuration
        .SetBasePath(builder.Environment.ContentRootPath)
        .AddJsonFile("appsettings.json",true,true)
        .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json",true, true)
        .AddEnvironmentVariables();

// *** Configurando servi�os no container ***

// Adicionando suporte a mudan�a de conven��o da rota das areas.
builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.AreaViewLocationFormats.Clear();
    options.AreaViewLocationFormats.Add("/Modules/{2}/Views/{1}/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Modules/{2}/Views/Shared/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
});

// Add context by EF
builder.Services.AddDbContext<EFContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EFContext")));


// Adicionando suporte ao MVC
builder.Services.AddControllersWithViews();

// Injecao de dependencia
builder.Services.AddTransient<IOrderRepository, OrderRepository>();

var app = builder.Build();

// *** Configurando o resquest dos servi�os no pipeline ***

if (app.Environment.IsDevelopment())
{
    //app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Adicionando suporte a rota
app.UseRouting();

// Rota padr�o
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Rota de �rea gen�rica (n�o necess�rio no caso da demo)
// app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// Rota de �reas especializadas
app.MapAreaControllerRoute("AreaProducts", "Products", "Products/{controller=Registration}/{action=Index}/{id?}");
app.MapAreaControllerRoute("AreaSales", "Sales", "Sales/{controller=Order}/{action=Index}/{id?}");

app.Run();