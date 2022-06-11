using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class BannerReadRepository : ReadRepository<Banner>, IBannerReadRepository
{
    public BannerReadRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
