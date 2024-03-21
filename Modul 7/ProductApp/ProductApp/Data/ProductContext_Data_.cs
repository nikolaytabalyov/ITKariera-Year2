using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data.Model;

    public class ProductContext_Data_ : DbContext
    {
        public ProductContext_Data_ (DbContextOptions<ProductContext_Data_> options)
            : base(options)
        {
        }

        public DbSet<Data.Model.Product> Product { get; set; } = default!;
    }
