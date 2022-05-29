using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PttAppAPI.Domain.Entity.Common;

namespace PttAppAPI.Domain.Entity;
public class Product : BaseEntity
{
    public int CategoryId { get; set; }
    public int SubCategoryId { get; set; }
    public int SubOfSubCategoryId { get; set; }
    public string? ProductIconSource { get; set; }

    public string? Title { get; set; }
    public float Price { get; set; }
    public string PriceWithTL => (Price.ToString() + ".00 TL");
}
