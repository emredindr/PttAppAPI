using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PttApp.Domain.Entities;
using PttAppAPI.Domain.Entity;

namespace PttAppAPI.Persistence.Contexts;
public class PttAppAPIDbContext : DbContext
{
    public PttAppAPIDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<MainCategory> MainCategories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<SubOfSubCategory> SubOfSubCategories { get; set; }
    public DbSet<AccountPageItem> AccountPageItems { get; set; }
    public DbSet<AccountPageItemLogined> AccountPageItemsLogined { get; set; }
    public DbSet<Banner> BannerItems { get; set; }
    public DbSet<MyBasketItem> MyBasketItems { get; set; }   
}
