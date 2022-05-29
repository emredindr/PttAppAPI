using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PttAppAPI.Domain.Entity;

namespace PttAppAPI.Persistence.Concretes;
public class PttAppAPIDbContext
{
    public class PttAPIDbContext : DbContext
    {
        public PttAPIDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
