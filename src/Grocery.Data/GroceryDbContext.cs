using Grocery.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Data
{
    public class GroceryDbContext : DbContext
    {    
        public GroceryDbContext(DbContextOptions<GroceryDbContext> options) 
            : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(property => property.Name)
                .HasColumnType("nvarchar(250)");
            modelBuilder.Entity<Product>()
                .Property(property => property.Id)
                .HasDefaultValueSql("NEWID()");
        }
    }
}
