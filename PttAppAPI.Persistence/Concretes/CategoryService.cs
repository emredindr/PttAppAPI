using PttApp.Domain.Entities;
using PttAppAPI.Application.Abstractions;

namespace PttAppAPI.Persistence.Concretes;
public class CategoryService : ICategoryService
{
    public List<MainCategory> GetMainCategories()
    {
        throw new NotImplementedException();
    }

    public List<SubCategory> GetSubCategories()
    {
        throw new NotImplementedException();
    }

    public List<SubOfSubCategory> GetSubOfSubCategories()
    {
        throw new NotImplementedException();
    }
}
