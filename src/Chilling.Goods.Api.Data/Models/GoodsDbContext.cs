using Microsoft.EntityFrameworkCore;

namespace Chilling.Goods.Api.Data.Models;

public class GoodsDbContext: DbContext
{
    public GoodsDbContext(DbContextOptions<GoodsDbContext> options) : base(options)
    {
    }
    
    public DbSet<BrandDbo> Brands { get; set; }
}