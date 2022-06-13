using PttApp.Domain.Entities;

namespace PttAppAPI.Application.Abstractions;
public interface ICategoryService
{
    List<MainCategory> GetMainCategories();
    List<SubCategory> GetSubCategories();
    List<SubOfSubCategory> GetSubOfSubCategories();


}
