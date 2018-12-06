using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Domain;
namespace ProductCatalogApi.Data
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CatalogBrand>(ConfigureCatalogBrand);
            builder.Entity<CatalogType>(ConfigureCatalogType);
            builder.Entity<CatalogItem>(ConfigureCatalogItem);
        }
    }
}