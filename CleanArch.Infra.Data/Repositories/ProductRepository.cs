using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Products>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Products> GetById(int? id)
        {
            return await _context.Products.FindAsync(id);
        }


        public void add(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }


        public void remove(Products product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void update(Products product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(Products mapProduct)
        {
            _context.Entry(mapProduct).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
