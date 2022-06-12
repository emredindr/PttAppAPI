using PttApp.Domain.Entities;

namespace PttAppAPI.Application.Abstractions;
public interface IHomeService
{
    List<Banner> GetBanners();
}
