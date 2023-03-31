using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GroceryDbContext>(options => options.UseSqlServer(configuration["GROCERY_CONNECTIONSTRING"]));
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
