using PttApp.Domain.Entities;

namespace PttApp.Application.Abstractions;

public interface IAccountService
{
    List<AccountPageItem> GetAccountPageItems();
    List<AccountPageItemLogined> GetAccountPageItemsLogined();
}