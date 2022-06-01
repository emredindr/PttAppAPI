using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PttAppAPI.Domain.Entity;

namespace PttAppAPI.Persistence.Contexts;
public class PttAppAPIDbContext : DbContext
{
    public PttAppAPIDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Product>Products { get; set; }
}
