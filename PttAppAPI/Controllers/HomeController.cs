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
        var products = _bannerReadRepository.GetAll();

        return products.ToList();
    }
    //[HttpPost]
    //public async Task AddAllBanner()
    //{
    //    var banners = _homeService.GetBanners();
    //    await _bannerWriteRepository.AddRangeAsync(banners);
    //    await _bannerWriteRepository.SaveAsync();
    //}

}
