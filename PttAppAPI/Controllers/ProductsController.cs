using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PttAppAPI.Application.Abstractions;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Domain.Entity;

namespace PttAppAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    //Services
    private readonly IProductService _productService;
    
    //Read Repositories
    private readonly IProductReadRepository _productReadRepository;

    //write Repositories
    private readonly IProductWriteRepository _productWriteRepository;
    public ProductsController
        (
        IProductService productService,
        IProductWriteRepository productWriteRepository,
        IProductReadRepository productReadRepository
        )
    {
        _productService = productService;
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
        
    }

    [HttpGet]
    public List<Product> GetAll()
    {
        var products = _productReadRepository.GetAll();

        return products.ToList();
    }
}
