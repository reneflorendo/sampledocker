using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace webapentityframeworkdocker.Models
{
    public class SeedingData
    {
        public static void PrePopulatedData(IApplicationBuilder app) 
        {
            using var serviceScope = app.ApplicationServices.CreateAsyncScope();
            PrePopulatedData(serviceScope.ServiceProvider.GetService<SalesContext>());
        }

        public static void PrePopulatedData(SalesContext salesContext)
        {
            Console.WriteLine("Applying Migrations...");
            salesContext.Database.Migrate();

            if (salesContext.Products.Any())
            {
                Console.WriteLine("Already have data - not seeding");
                return; // No need to continue if data already exists
            }

            Console.WriteLine("Adding data - seeding");

            var productsToAdd = new List<Product>
    {
        new Product
        {
            Code = "123",
            Description = "Product 1",
            Name = "S-23",
            Price = 1234,
            ProductCategory = ProductCategory.Clothing,
            SKU = "123"
        },
        new Product
        {
            Code = "345",
            Description = "Product 2",
            Name = "Nike Air",
            Price = 4567,
            ProductCategory = ProductCategory.Footware,
            SKU = "345"
        }
        // Add more products as needed
    };

            salesContext.Products.AddRange(productsToAdd);
            salesContext.SaveChanges();
        }

    }
}
