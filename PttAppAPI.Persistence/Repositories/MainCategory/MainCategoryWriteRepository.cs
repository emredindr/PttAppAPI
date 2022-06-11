using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class MainCategoryWriteRepository : WriteRepository<MainCategory>, IMainCategoryWriteRepository
{
    public MainCategoryWriteRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
