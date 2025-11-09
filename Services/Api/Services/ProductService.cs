using Api.Contracts.IServices;
using Api.Models;

namespace Api.Services;

public class ProductService : IProductService
{
    public List<Product> GetProducts()
    {
        var products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 1200.99m },
        new Product { Id = 2, Name = "Smartphone", Description = "Latest smartphone model", Price = 899.50m },
        new Product { Id = 3, Name = "Headphones", Description = "Noise-cancelling headphones", Price = 199.99m },
        new Product { Id = 4, Name = "Keyboard", Description = "Mechanical keyboard", Price = 79.99m },
        new Product { Id = 5, Name = "Mouse", Description = "Wireless ergonomic mouse", Price = 49.99m }
    };

        return products;
    }
}
