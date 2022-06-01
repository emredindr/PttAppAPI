using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Domain.Entity.Common;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly PttAppAPIDbContext _context;
    public ReadRepository(PttAppAPIDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    //=> Table;
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = query.AsNoTracking();
        }
        return query;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
    //=> Table.Where(method);
    {
        var query = Table.Where(method);
        if (!tracking)
        {
            query = query.AsNoTracking();
        }
        return query;
    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
    //=> await Table.FirstOrDefaultAsync(method);
    {
        var query = Table.AsQueryable();
        if (!tracking)
        {
            query = query.AsNoTracking();
        }
        return await query.FirstOrDefaultAsync(method);
    }

    public Task<T> GetByIdAsync(string id, bool tracking = true)
    {
        throw new NotImplementedException();
    }

    //public async Task<T> GetByIdAsync(string id, bool tracking = true)
    //// => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    //// =>  await Table.FindAsync(Guid.Parse(id));
    //{
    //    var query = Table.AsQueryable();
    //    if (!tracking)
    //    {
    //        query = Table.AsNoTracking();
    //    }
    //    //IQueryable ile çalışırken FindAsync f onksiyonuna erişilmez. Bu yüzden marker pattern ürerinden (id üzerinden) sorgulama sağlanır.
    //    return await query.FirstOrDefaultAsync(data => data.Id == Convert.ToInt32(id));
    //}
}