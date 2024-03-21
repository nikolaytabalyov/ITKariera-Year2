using CRUDappWithORM.Data.Models;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9LO8QGB;Database=ProductDB;Integrated Security = true;Encrypt=false;");
        }
    }
}
