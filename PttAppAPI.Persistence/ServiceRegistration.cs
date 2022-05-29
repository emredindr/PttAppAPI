using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PttAppAPI.Application.Abstractions;
using PttAppAPI.Persistence.Concretes;
using static PttAppAPI.Persistence.Concretes.PttAppAPIDbContext;

namespace PttAppAPI.Persistence;
public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
        services.AddDbContext<PttAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
    }
}
