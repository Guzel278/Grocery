﻿using Grocery.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Data
{
    public class ProductRepository : IProductRepository
    {
        private GroceryDbContext _dbContext;
        public ProductRepository(GroceryDbContext groceryDbContext) 
        {
            _dbContext = groceryDbContext;
        }
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
            
            //List<Product> products = new List<Product>();
            //products.Add(new Product() { Name = "Rise", Id = Guid.NewGuid() });
            //products.Add(new Product() { Name = "Chiken breast", Id = Guid.NewGuid() });
            //return Task.FromResult((IEnumerable<Product>)products);
        }
    }
}
