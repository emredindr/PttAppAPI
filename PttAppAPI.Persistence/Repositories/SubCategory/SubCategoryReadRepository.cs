using PttApp.Domain.Entities;
using PttAppAPI.Persistence.Contexts;
using PttAppAPI.Persistence.Repositories;

namespace PttAppAPI.Application.Repositories;
public class SubCategoryReadRepository : ReadRepository<SubCategory>, ISubCategoryReadRepository
{
    public SubCategoryReadRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
