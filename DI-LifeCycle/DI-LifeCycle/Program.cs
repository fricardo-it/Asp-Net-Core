using DI_LifeCycle.Services;
using Microsoft.AspNetCore.Mvc.Razor;

// Builder principal é dele de onde tudo deriva
var builder = WebApplication.CreateBuilder(args);

// *** Configurando serviços no container ***

// Adicionando suporte a mudança de convenção da rota das areas.
builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.AreaViewLocationFormats.Clear();
    options.AreaViewLocationFormats.Add("/Modules/{2}/Views/{1}/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Modules/{2}/Views/Shared/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
});


//builder.Services.AddDbContext<MeuDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("MeuDbContext")));

// Adicionando suporte ao MVC
builder.Services.AddControllersWithViews();

// Injecao de dependencia
//builder.Services.AddTransient<IOrderRepository, OrderRepository>();

builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();
builder.Services.AddSingleton<IOperationSingletonInstance>(new Operation(Guid.Empty));

builder.Services.AddTransient<OperationService>();

//builder.Services.AddScoped<MeuDbContext>();

var app = builder.Build();

// *** Configurando o resquest dos serviços no pipeline ***

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

// Rota padrão
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();