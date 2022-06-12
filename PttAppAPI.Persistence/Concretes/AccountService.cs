using PttApp.Application.Abstractions;
using PttApp.Domain.Entities;

namespace PttAppAPI.Persistence.Concretes;
public class AccountService : IAccountService
{
    public List<AccountPageItem> GetAccountPageItems()
    {
        List<AccountPageItem> items = new List<AccountPageItem>()
            {
                new AccountPageItem()
                {
                   Id = 1,
                   Title = "HGS Yükle",
                   Url="https://play.google.com/store/apps/details?id=tr.com.ulkem.hgs&hl=tr&gl=US",


                }
                ,new AccountPageItem()
                {
                   Id = 2,
                   Title = "Kanpanyalar",

                },
                new AccountPageItem()
                {
                   Id = 3,
                   Title = "Günün Fırsatları",

                },
                new AccountPageItem()
                {
                   Id = 4,
                   Title = "Hediye Bul",

                },
                new AccountPageItem()
                {
                   Id = 5,
                   Title = "Mağazalar",

                },
                new AccountPageItem()
                {
                   Id = 6,
                   Title = "Banka Hesapları",

                },
                new AccountPageItem()
                {
                   Id = 7,
                   Title = "Yardım",

                }
            };
        return items;

    }

    public List<AccountPageItemLogined> GetAccountPageItemsLogined()
    {
        List<AccountPageItemLogined> items = new List<AccountPageItemLogined>()
            {
                new AccountPageItemLogined()
                {
                   Id = 1,
                   Title = "Sipariş Takip",
                   ImageSource="kargo"
                }
                ,new AccountPageItemLogined()
                {
                   Id = 2,
                   Title = "Kişisel Bilgilerim",
                   ImageSource="person"

                },
                new AccountPageItemLogined()
                {
                   Id = 3,
                   Title = "Adres Yönetimi",
                   ImageSource="adress"

                },
                new AccountPageItemLogined()
                {
                   Id = 4,
                   Title = "Yorumlarım",
                   ImageSource="comment"

                },
                new AccountPageItemLogined()
                {
                   Id = 5,
                   Title = "Şifre Değiştir",
                   ImageSource="password"

                },
                new AccountPageItemLogined()
                {
                   Id = 6,
                   Title = "Banka Hesapları",
                   ImageSource="bank"

                },
                new AccountPageItemLogined()
                {
                   Id = 7,
                   Title = "Yardım",
                   ImageSource="help"

                },

                new AccountPageItemLogined()
                {
                   Id = 8,
                   Title = "Çıkış yap",
                   ImageSource="logout"

                }
            };
        return items;
    }
}
