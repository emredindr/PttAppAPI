using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class BannerWriteRepository : WriteRepository<Banner>, IBannerWriteRepository
{
    public BannerWriteRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
