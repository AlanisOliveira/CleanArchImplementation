using Microsoft.EntityFrameworkCore;
using CleanArch.Infra.IoC;
using CleanArch.MVC.MappingConfig;


var builder = WebApplication.CreateBuilder(args);

// Configuração do DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (connectionString != null)
{
    DependencyInjection.AddDbContext(builder.Services, connectionString);
}
else
{
    throw new ArgumentNullException("Connection string not found");
}

// Configuração do Identity
DependencyInjection.AddIdentity(builder.Services);

// Configuração do AutoMapper
builder.Services.AddAutoMapperConfiguration();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure o pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
