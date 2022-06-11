using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class AccountPageItemLoginedReadRepository : ReadRepository<AccountPageItemLogined>, IAccountPageItemLoginedReadRepository
{
    public AccountPageItemLoginedReadRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
