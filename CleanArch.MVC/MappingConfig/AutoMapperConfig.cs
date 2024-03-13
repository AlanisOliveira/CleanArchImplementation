using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CleanArch.Application.Mappings;

namespace CleanArch.MVC.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if(services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(NewClassViewModelToDomainMappingProfile));
        }
    }
}