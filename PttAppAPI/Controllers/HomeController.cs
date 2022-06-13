using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PttApp.Domain.Entities;
using PttAppAPI.Application.Abstractions;
using PttAppAPI.Application.Repositories;

namespace PttAppAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IHomeService _homeService;
    private readonly IBannerReadRepository _bannerReadRepository;
    private readonly IBannerWriteRepository _bannerWriteRepository;
    public HomeController
       (
        IHomeService homeService,
        IBannerWriteRepository bannerWriteRepository,
        IBannerReadRepository bannerReadRepository
       )
       {
        _homeService = homeService; 
        _bannerWriteRepository = bannerWriteRepository;
        _bannerReadRepository = bannerReadRepository;
       }
    
    [HttpGet]
    public List<Banner> GetAll()
    {
        var banners = _bannerReadRepository.GetAll();

        return banners.ToList();
    }

}
