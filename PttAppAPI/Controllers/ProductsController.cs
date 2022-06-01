using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PttAppAPI.Application.Abstractions;

namespace PttAppAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var product = _productService.GetAllProducts();

        return Ok(product);
    }

    
}
