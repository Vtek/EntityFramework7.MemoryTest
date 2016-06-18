using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace TestE7
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options)
        : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}

