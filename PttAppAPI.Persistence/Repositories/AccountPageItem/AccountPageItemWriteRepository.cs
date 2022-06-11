using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class AccountPageItemWriteRepository : WriteRepository<AccountPageItem>, IAccountPageItemWriteRepository
{
    public AccountPageItemWriteRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
