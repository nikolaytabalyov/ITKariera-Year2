using CRUDappWithORM.Data.Models;
using CRUDappWithORMv2.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CRUDappWithORM.Data {
    public class ProductContext : DbContext {
        public ProductContext() 
            : base() {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } // Include the DbSet for Category

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9LO8QGB;Database=ProductDBv2;Integrated Security = true;Encrypt=false;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Configure the relationship between Product and Category
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId)
                .IsRequired(false); // Allow products without categories
        }
    }
}
