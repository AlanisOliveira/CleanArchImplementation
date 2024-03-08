using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetProducts();
    }
}