using Microsoft.EntityFrameworkCore;

namespace Chilling.Goods.Api.Data.Models;

public class GoodsDbContext : DbContext
{
    public GoodsDbContext(DbContextOptions<GoodsDbContext> options) : base(options)
    {
    }

    public DbSet<BrandDbo> Brand { get; set; }
    public DbSet<CatalogDbo> Catalog { get; set; }
    public DbSet<ProductTypeDbo> ProductType { get; set; }
    public DbSet<ProductTypeBrandConventionDbo> ProductTypeBrands { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatalogDbo>().ToTable("Catalog")
            .HasMany(x => x.ProductTypes)
            .WithOne(x => x.Catalog);
        modelBuilder.Entity<ProductTypeDbo>().ToTable("ProductType")
            .HasOne(x => x.Catalog)
            .WithMany(x => x.ProductTypes);
        modelBuilder.Entity<ProductTypeDbo>()
            .HasMany(x => x.Brands)
            .WithOne(x => x.ProductType);
        modelBuilder.Entity<BrandDbo>().ToTable("Brand")
            .HasMany(x => x.ProductTypes)
            .WithOne(x => x.Brand);

        modelBuilder.Entity<ProductTypeBrandConventionDbo>().ToTable("ProducTypeBrands")
            .HasKey(x => new { x.ProductTypeId, x.BrandId });
        modelBuilder.Entity<ProductTypeBrandConventionDbo>()
            .HasOne(x => x.Brand)
            .WithMany(x => x.ProductTypes)
            .HasForeignKey(x => x.BrandId);
        modelBuilder.Entity<ProductTypeBrandConventionDbo>()
            .HasOne(x => x.ProductType)
            .WithMany(x => x.Brands)
            .HasForeignKey(x => x.ProductTypeId);
    }
}