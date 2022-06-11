using PttApp.Domain.Entities;

namespace PttAppAPI.Application.Abstractions;
public interface IMainCategoryService
{
    List<MainCategory> GetMainCategories();
    

}
