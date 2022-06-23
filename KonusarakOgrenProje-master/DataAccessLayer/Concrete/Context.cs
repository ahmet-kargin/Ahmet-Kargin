using DataAccessLayer.Concrete.EntityConfig;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MK\\SQLEXPRESS;Database=Merhaba;integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<ProductSize>()
                .HasKey(pc => new { pc.SizeId, pc.ProductId });
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfig).Assembly);
        }

    }
}
