using Api.Models;

namespace Api.Contracts.IServices;

public interface IProductService
{
    public List<Product> GetProducts();
}
