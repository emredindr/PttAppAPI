using Microsoft.AspNetCore.Mvc;
using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;


namespace PttAppAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MyBasketController : ControllerBase
{
    private readonly IMyBasketItemWriteRepository _myBasketItemWriteRepository;
    public MyBasketController(IMyBasketItemWriteRepository myBasketItemWriteRepository)
    {
        _myBasketItemWriteRepository = myBasketItemWriteRepository;
    }
    // GET: api/<ValuesController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<ValuesController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ValuesController>
    [HttpPost]
    [Route("AddBasket")]
    public int AddBasket([FromBody] MyBasketItem myBasketItem)
    {
        _myBasketItemWriteRepository.AddAsync(myBasketItem);
        var id = _myBasketItemWriteRepository.SaveAsync();
        return id.Result;

    }

    // PUT api/<ValuesController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ValuesController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
