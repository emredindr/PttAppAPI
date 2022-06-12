using PttApp.Domain.Entities;
using PttAppAPI.Application.Abstractions;

namespace PttAppAPI.Persistence.Concretes;
public class HomeService : IHomeService
{
    public List<Banner> GetBanners()
    {
        List<Banner> banners = new List<Banner>()
            {
                new Banner()
                {
                    Image = "firsaturunu1.png"
                },
                new Banner()
                {
                    Image = "firsaturunu2.png"
                },
                new Banner()
                {
                    Image = "firsaturunu3.png"
                },
                new Banner()
                {
                    Image = "firsaturunu4.png"
                },
                new Banner()
                {
                    Image = "firsaturunu5.png"
                },
                new Banner()
                {
                    Image = "firsaturunu6.png"
                },
                new Banner()
                {
                    Image = "firsaturunu7.png"
                },
                new Banner()
                {
                    Image = "firsaturunu8.png"
                },
                new Banner()
                {
                    Image = "firsaturunu10.png"
                },
                new Banner()
                {
                    Image = "firsaturunu11.png"
                }

            };
        return banners;
    }
}
