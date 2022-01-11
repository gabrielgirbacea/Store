using Microsoft.Extensions.Logging;
using Store.Core.Entities;
using Store.Data.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Store.Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.ProductBrands.Any())
                {
                    var productBrandsData = await File.ReadAllTextAsync("../Store.Infrastructure/Data/SeedData/productBrands.json");
                    var productbrands = JsonSerializer.Deserialize<List<ProductBrand>>(productBrandsData);

                    foreach (var brand in productbrands)
                    {
                        context.ProductBrands.Add(brand);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.ProductTypes.Any())
                {
                    var productTypeData = await File.ReadAllTextAsync("../Store.Infrastructure/Data/SeedData/productTypes.json");
                    var productTypes = JsonSerializer.Deserialize<List<ProductType>>(productTypeData);

                    foreach (var type in productTypes)
                    {
                        context.ProductTypes.Add(type);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    var productsData = await File.ReadAllTextAsync("../Store.Infrastructure/Data/SeedData/products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    foreach (var product in products)
                    {
                        context.Products.Add(product);
                    }
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception exception)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(exception.Message);

                throw;
            }
        }
    }
}
