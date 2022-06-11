using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class AccountPageItemReadRepository : ReadRepository<AccountPageItem>, IAccountPageItemReadRepository
{
    public AccountPageItemReadRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
