using PttApp.Domain.Entities;

namespace PttAppAPI.Application.Abstractions;
public interface ICategoryService
{
    List<MainCategory> GetMainCategories();
    List<SubCategory> GetSubCategories();
    List<SubOfSubCategory> GetSubOfSubCategories();
    List<SubCategory> GetSubCategories(MainCategory mainCategory);
    List<SubOfSubCategory> GetSubOfSubCategories(SubCategory subCategory);
    List<SubCategory> GetElektronicPopulerCategories();
    List<SubCategory> GetBabyPopulerCategories();

}
