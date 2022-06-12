using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PttApp.Application.Abstractions;
using PttApp.Domain.Entities;

namespace PttAppAPI.Persistence.Concretes;
public class AccountService : IAccountService
{
    public List<AccountPageItem> GetAccountPageItems()
    {
        throw new NotImplementedException();
    }

    public List<AccountPageItemLogined> GetAccountPageItemsLogined()
    {
        throw new NotImplementedException();
    }
}
