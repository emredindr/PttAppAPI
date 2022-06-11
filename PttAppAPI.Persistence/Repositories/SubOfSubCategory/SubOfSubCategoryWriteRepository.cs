using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
internal class SubOfSubCategoryWriteRepository : WriteRepository<SubOfSubCategory>, ISubOfSubCategoryWriteRepository
{
    public SubOfSubCategoryWriteRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
