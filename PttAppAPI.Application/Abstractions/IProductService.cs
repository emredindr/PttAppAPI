using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PttApp.Domain.Entities;
using PttAppAPI.Domain.Entity;

namespace PttAppAPI.Application.Abstractions;

public interface IProductService
{
    List<Product> GetAllProducts();
    List<Product> GetProducts(ProductFilter productFilter);
    Product GetProductById(int productId);
}
