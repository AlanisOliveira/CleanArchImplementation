using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.IoC
{
    public static class DependencyInjection
    {
        public static void AddDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            
        }

        public static void AddIdentity(IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }
    }
}
