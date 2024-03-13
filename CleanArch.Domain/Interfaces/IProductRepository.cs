using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Products>> GetProducts();
        Task<Products> GetById(int? id);
        void add(Products product);
        void update(Products product);
        void remove(Products product);
        void Update(Products mapProduct);
    }
}