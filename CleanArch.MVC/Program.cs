using Microsoft.EntityFrameworkCore;
using CleanArch.Infra.IoC;


var builder = WebApplication.CreateBuilder(args);

// Configuração do DbContext
DependencyInjection.AddDbContext(builder.Services, builder.Configuration.GetConnectionString("DefaultConnection"));

// Configuração do Identity
DependencyInjection.AddIdentity(builder.Services);

// Adicione outros serviços necessários
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
