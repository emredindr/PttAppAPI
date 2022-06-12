using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PttApp.Application.Abstractions;
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

    [HttpPost]
    public async Task AddAllItemLogined()
    {
        var datas = _accountService.GetAccountPageItemsLogined();
        await _accountPageItemLoginedWriteRepository.AddRangeAsync(datas);
        await _accountPageItemLoginedWriteRepository.SaveAsync();
    }
}
