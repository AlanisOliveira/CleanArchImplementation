using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(t => t.Name).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Price).HasPrecision(10, 2);

            builder.HasData(
                new Products
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno espiral 100 folhas",
                    Price = 7.45m
                },
                new Products
                {
                    Id = 2,
                    Name = "Borracha",
                    Description = "Borracha branca",
                    Price = 3.75m
                },
                new Products
                {
                    Id = 3,
                    Name = "Estojo",
                    Description = "Estojo escolar",
                    Price = 5.25m
                }
            );
        }
    }
}