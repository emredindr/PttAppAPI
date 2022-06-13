using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PttApp.Application.Abstractions;
using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;

namespace PttAppAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    //Read   
    private readonly IAccountPageItemReadRepository _accountPageItemReadRepository;
    private readonly IAccountPageItemLoginedReadRepository _accountPageItemLoginedReadRepository;
    //Write
    private readonly IAccountPageItemWriteRepository _accountPageItemWriteRepository;
    private readonly IAccountPageItemLoginedWriteRepository _accountPageItemLoginedWriteRepository;
    public AccountController
        (
        IAccountService accountService,
        IAccountPageItemReadRepository accountPageItemReadRepository, 
        IAccountPageItemLoginedReadRepository accountPageItemLoginedReadRepository,
        IAccountPageItemWriteRepository accountPageItemWriteRepository,
        IAccountPageItemLoginedWriteRepository accountPageItemLoginedWriteRepository
        )
    {
        _accountService = accountService;
        _accountPageItemReadRepository = accountPageItemReadRepository;
        _accountPageItemLoginedReadRepository = accountPageItemLoginedReadRepository;
        _accountPageItemWriteRepository = accountPageItemWriteRepository;
        _accountPageItemLoginedWriteRepository = accountPageItemLoginedWriteRepository;
    }
    [HttpGet]
    [Route("GetAllItems")]
    public List<AccountPageItem> GetAllItems()
    {
        var items = _accountPageItemReadRepository.GetAll();

        return items.ToList();
    }
    
    [HttpGet]
    [Route("GetAllItemsLogined")]
    public List<AccountPageItem> GetAllItemsLogined()
    {
        var items = _accountPageItemReadRepository.GetAll();

        return items.ToList();
    }

}
