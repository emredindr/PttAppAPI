using PttApp.Domain.Entities;
using PttAppAPI.Persistence.Contexts;
using PttAppAPI.Persistence.Repositories;

namespace PttAppAPI.Application.Repositories;
public class SubCategoryWriteRepository : WriteRepository<SubCategory>, ISubCategoryWriteRepository
{
    public SubCategoryWriteRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
