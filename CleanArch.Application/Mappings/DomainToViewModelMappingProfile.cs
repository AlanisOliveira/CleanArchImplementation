using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Products, ProductViewModel>();
        }
        
    }

}