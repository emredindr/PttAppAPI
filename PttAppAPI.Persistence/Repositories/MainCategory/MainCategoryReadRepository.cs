using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class MainCategoryReadRepository : ReadRepository<MainCategory>, IMainCategoryReadRepository
{
    public MainCategoryReadRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
