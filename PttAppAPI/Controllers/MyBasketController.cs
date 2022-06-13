using Microsoft.AspNetCore.Mvc;
using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;


namespace PttAppAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MyBasketController : ControllerBase
{
    private readonly IMyBasketItemWriteRepository _myBasketItemWriteRepository;
    private readonly IMyBasketItemReadRepository _myBasketItemReadRepository;
    public MyBasketController(IMyBasketItemWriteRepository myBasketItemWriteRepository, IMyBasketItemReadRepository myBasketItemReadRepository)
    {
        _myBasketItemWriteRepository = myBasketItemWriteRepository;
        _myBasketItemReadRepository = myBasketItemReadRepository;
    }
    [HttpGet]
    public List<MyBasketItem> GetAllBasketItem()
    {
        var datas = _myBasketItemReadRepository.GetAll();

        return datas.ToList();
    }

    
    [HttpPost]
    [Route("AddBasket")]
    public int AddBasket([FromBody] MyBasketItem myBasketItem)
    {
        _myBasketItemWriteRepository.AddAsync(myBasketItem);
        var id = _myBasketItemWriteRepository.SaveAsync();
        return id.Result;

    }

    [HttpDelete("{id}")]
    public int Delete([FromBody] MyBasketItem myBasketItem)
    {
        _myBasketItemWriteRepository.RemoveAsync(myBasketItem.Id.ToString());
        var id = _myBasketItemWriteRepository.SaveAsync();
        return id.Result;
    }
}
