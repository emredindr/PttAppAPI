using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PttAppAPI.Application.Abstractions;
using PttAppAPI.Persistence.Concretes;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence;
public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
        //services.AddDbContext<PttAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Singleton);
        services.AddDbContext<PttAppAPIDbContext>(option => option.UseSqlServer(Configuration.ConnectionString));
    }
}
