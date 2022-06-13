using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PttApp.Domain.Entities;
using PttAppAPI.Application.Abstractions;
using PttAppAPI.Application.Repositories;

namespace PttAppAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    //read
    private readonly IMainCategoryReadRepository _mainCategoryReadRepository;
    private readonly ISubCategoryReadRepository _subCategoryReadRepository;
    private readonly ISubOfSubCategoryReadRepository _subOfSubCategoryReadRepository;
    //Write
    private readonly IMainCategoryWriteRepository _mainCategoryWriteRepository;
    private readonly ISubCategoryWriteRepository _subCategoryWriteRepository;
    private readonly ISubOfSubCategoryWriteRepository _subOfSubCategoryWriteRepository;

    public CategoryController
        (
        ICategoryService categoryService,
        IMainCategoryReadRepository mainCategoryReadRepository,
        IMainCategoryWriteRepository mainCategoryWriteRepository,
        ISubCategoryReadRepository subCategoryReadRepository,
        ISubCategoryWriteRepository subCategoryWriteRepository,
        ISubOfSubCategoryWriteRepository subOfSubCategoryWriteRepository,
        ISubOfSubCategoryReadRepository subOfSubCategoryReadRepository
        )
    {
        _categoryService = categoryService;
        _mainCategoryReadRepository = mainCategoryReadRepository;
        _mainCategoryWriteRepository = mainCategoryWriteRepository;
        _subCategoryWriteRepository = subCategoryWriteRepository;
        _subCategoryReadRepository = subCategoryReadRepository;
        _subOfSubCategoryReadRepository = subOfSubCategoryReadRepository;
        _subOfSubCategoryWriteRepository = subOfSubCategoryWriteRepository;
    }

    [HttpGet]
    [Route("GetAllSubOfSubCategories")]
    public List<SubOfSubCategory> GetAllSubOfSubCategories()
    {
        var item = _subOfSubCategoryReadRepository.GetAll();

        return item.ToList();

    }
    [HttpGet]
    [Route("GetAllSubCategories")]
    public List<SubCategory> GetAllSubCategories()
    {
        var item = _subCategoryReadRepository.GetAll();

        return item.ToList();

    }
    [HttpGet]
    [Route("GetAllMainCategories")]
    public List<MainCategory> GetAllMainCategories()
    {
        var item = _mainCategoryReadRepository.GetAll();

        return item.ToList();

    }


}
