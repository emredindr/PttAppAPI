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
    [Route("GetAllBasketItem")]
    public List<MyBasketItem> GetAllBasketItem()
    {
        var datas = _myBasketItemReadRepository.GetAll();

        return datas.ToList();
    }


    [HttpPost]
    [Route("AddBasketItem")]
    public int AddBasket([FromBody] MyBasketItem myBasketItem)
    {
        _myBasketItemWriteRepository.AddAsync(myBasketItem);
        var id = _myBasketItemWriteRepository.SaveAsync();
        return id.Result;

    }

    [HttpPost]
    [Route("DeleteItem")]
    public async Task Delete([FromBody] int id)
    {
        await _myBasketItemWriteRepository.RemoveAsync(id);
        await _myBasketItemWriteRepository.SaveAsync();
    }

    [HttpPost]
    [Route("DeleteAll")]
    public async Task Delete()
    {
        _myBasketItemWriteRepository.RemoveAll();
        await _myBasketItemWriteRepository.SaveAsync();
    }
}
