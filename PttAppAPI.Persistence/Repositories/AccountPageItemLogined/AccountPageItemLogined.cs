using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PttApp.Domain.Entities;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class AccountPageItemLoginedWriteRepository : WriteRepository<AccountPageItemLogined>,IAccountPageItemLoginedWriteRepository
{
    public AccountPageItemLoginedWriteRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
