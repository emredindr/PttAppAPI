using PttApp.Domain.Entities;
using PttAppAPI.Application.Abstractions;
using PttAppAPI.Domain.Entity;

namespace PttAppAPI.Persistence.Concretes;

public class ProductService : IProductService
{
    public List<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product GetProductById(int productId)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProducts(ProductFilter productFilter)
    {
        throw new NotImplementedException();
    }
}
