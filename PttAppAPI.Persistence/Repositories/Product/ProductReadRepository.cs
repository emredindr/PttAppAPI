using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PttAppAPI.Application.Repositories;
using PttAppAPI.Domain.Entity;
using PttAppAPI.Persistence.Contexts;

namespace PttAppAPI.Persistence.Repositories;
public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(PttAppAPIDbContext context) : base(context)
    {
    }
}
