using Grocery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Data
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<Product>> GetProductsAsync()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "Rise", Id = Guid.NewGuid() });
            products.Add(new Product() { Name = "Chiken breast", Id = Guid.NewGuid() });
            return Task.FromResult((IEnumerable<Product>)products);
        }
    }
}
