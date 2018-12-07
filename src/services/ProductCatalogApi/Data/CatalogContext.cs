using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ProductCatalogApi.Data
{
    public class CatalogContext : DbContext
    {
        public DbSet<CatalogType> CatalogTypes { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public CatalogContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CatalogBrand>(ConfigureCatalogBrand);
            builder.Entity<CatalogType>(ConfigureCatalogType);
            builder.Entity<CatalogItem>(ConfigureCatalogItem);
        }

        private void ConfigureCatalogBrand(EntityTypeBuilder<CatalogBrand> builder)
        {
             builder.ToTable("CatalogBrand"); 
           builder.Property(c=>c.Id).ForSqlServerUseSequenceHiLo("catalog_brand_hilo")
           .IsRequired(true);

           builder.Property(c=>c.Brand)
           .IsRequired(true)
           .HasMaxLength(50);

        }
        private void ConfigureCatalogType(EntityTypeBuilder<CatalogType> builder)
        {
            builder.ToTable("CatalogType"); 
           builder.Property(c=>c.Id).ForSqlServerUseSequenceHiLo("catalog_type_hilo")
           .IsRequired(true);

           builder.Property(c=>c.Type)
           .IsRequired(true)
           .HasMaxLength(50);
            
        }
        private void ConfigureCatalogItem(EntityTypeBuilder<CatalogItem> builder)
        {
           builder.ToTable("Catalog"); 
           builder.Property(c=>c.Id).ForSqlServerUseSequenceHiLo("catalog_hilo")
           .IsRequired(true);

           builder.Property(c=>c.Name)
           .IsRequired(true)
           .HasMaxLength(50);

           builder.Property(c=>c.Price).IsRequired(true);
           builder.HasOne(c=>c.CatalogBrand)
           .WithMany()
           .HasForeignKey(c=>c.CatalogBrandId);

           builder.HasOne(c=>c.CatalogType)
           .WithMany()
           .HasForeignKey(c=>c.CatalogTypeId);
        }
    }
}