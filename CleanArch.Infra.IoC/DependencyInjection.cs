using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CleanArch.Infra.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repositories;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;

namespace CleanArch.Infra.IoC
{
    public static class DependencyInjection
    {
        public static void AddDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            
        }

        public static void AddIdentity(IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }

    }
}
