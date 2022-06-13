using PttAppAPI.Domain.Entity.Common;

namespace PttAppAPI.Application.Repositories;
public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    bool Add(T model);
    Task<bool> AddRangeAsync(List<T> datas);
    bool RemoveRance(List<T> datas);
    bool Remove(T model);
    Task<bool> RemoveAsync(string id);
    bool Update(T model);
    Task<int> SaveAsync();

}