using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PttApp.Application.Abstractions;
using PttAppAPI.Application.Abstractions;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Persistence.Concretes;
using PttAppAPI.Persistence.Contexts;
using PttAppAPI.Persistence.Repositories;

namespace PttAppAPI.Persistence;
public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
        services.AddSingleton<IHomeService, HomeService>();
        services.AddSingleton<ICategoryService, CategoryService>();
        services.AddSingleton< IAccountService , AccountService>();
        services.AddSingleton<ICategoryService, CategoryService>();
        services.AddDbContext<PttAppAPIDbContext>(options => options.UseSqlServer("server=.;database=PttAppDatabase;User Id=emre;Password=emre77;"), ServiceLifetime.Singleton);
        //services.AddDbContext<PttAppAPIDbContext>(option => option.UseSqlServer(Configuration.ConnectionString));
        //Read Scopeds
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IMainCategoryReadRepository,MainCategoryReadRepository>();
        services.AddScoped<IMyBasketItemReadRepository,MyBasketItemReadRepository> ();
        services.AddScoped<ISubOfSubCategoryReadRepository, SubOfSubCategoryReadRepository>();
        services.AddScoped<ISubCategoryReadRepository, SubCategoryReadRepository>();
        services.AddScoped<IBannerReadRepository,BannerReadRepository>();
        services.AddScoped<IAccountPageItemLoginedReadRepository,AccountPageItemLoginedReadRepository>();
        services.AddScoped<IAccountPageItemReadRepository, AccountPageItemReadRepository>();
        
        //Write Scopeds
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        services.AddScoped<IMainCategoryWriteRepository, MainCategoryWriteRepository>();
        services.AddScoped<IAccountPageItemLoginedWriteRepository, AccountPageItemLoginedWriteRepository>();
        services.AddScoped<IAccountPageItemWriteRepository,AccountPageItemWriteRepository >();
        services.AddScoped<ISubCategoryWriteRepository,SubCategoryWriteRepository>();
        services.AddScoped<ISubOfSubCategoryWriteRepository,SubOfSubCategoryWriteRepository >();
        services.AddScoped<IMyBasketItemWriteRepository,MyBasketItemWriteRepository >();
        services.AddScoped<IBannerWriteRepository,BannerWriteRepository>();
    }
}
