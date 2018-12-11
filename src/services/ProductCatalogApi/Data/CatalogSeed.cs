using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCatalogApi.Domain;

namespace ProductCatalogApi.Data
{
    public class CatalogSeed
    {
        public static async Task SeedAsync(CatalogContext context)
        {
            if(!context.CatalogBrands.Any())
               await context.CatalogBrands.AddRangeAsync(GetBrands());
            if(!context.CatalogTypes.Any())   
               await context.CatalogTypes.AddRangeAsync(GetCatalogTypes());
            if(!context.CatalogItems.Any())   
               await context.CatalogItems.AddRangeAsync(GetCatalogItems());
            await context.SaveChangesAsync();
        }
        static IEnumerable<CatalogBrand> GetBrands()
        {
            return new List<CatalogBrand>{
               new CatalogBrand{ Brand = "Brand 1"},
               new CatalogBrand{ Brand = "Brand 2"},
               new CatalogBrand{ Brand = "Brand 3"},
               new CatalogBrand{ Brand = "Brand 4"},
               new CatalogBrand{ Brand = "Brand 5"},
            };
        }

        static IEnumerable<CatalogType> GetCatalogTypes()
        {
            return new List<CatalogType>{
                new CatalogType{ Type = "Type 1"},
                new CatalogType{ Type = "Type 2"},
                new CatalogType{ Type = "Type 3"},
                new CatalogType{ Type = "Type 4"}
            };
        }

        static IEnumerable<CatalogItem> GetCatalogItems()
        {
            return new List<CatalogItem>{
              new CatalogItem{ Name="Item 1", Description="Desc 1", Price=1m, PictureFileName="pic1", PictureUrl="https://replacepart/api/pic/1"
              , CatalogBrandId=1, CatalogTypeId=1},
              new CatalogItem{ Name="Item 2", Description="Desc 2", Price=2m, PictureFileName="pic2", PictureUrl="https://replacepart/api/pic/2"
              , CatalogBrandId=1, CatalogTypeId=1},
               new CatalogItem{ Name="Item 3", Description="Desc 3", Price=20m, PictureFileName="pic3", PictureUrl="https://replacepart/api/pic/3"
              , CatalogBrandId=2, CatalogTypeId=1},
               new CatalogItem{ Name="Item 4", Description="Desc 4", Price=25m, PictureFileName="pic4", PictureUrl="https://replacepart/api/pic/4"
              , CatalogBrandId=3, CatalogTypeId=1},
               new CatalogItem{ Name="Item 5", Description="Desc 5", Price=50m, PictureFileName="pic5", PictureUrl="https://replacepart/api/pic/5"
              , CatalogBrandId=4, CatalogTypeId=2},
               new CatalogItem{ Name="Item 6", Description="Desc 6", Price=102m, PictureFileName="pic6", PictureUrl="https://replacepart/api/pic/6"
              , CatalogBrandId=1, CatalogTypeId=2},
               new CatalogItem{ Name="Item 7", Description="Desc 7", Price=200m, PictureFileName="pic7", PictureUrl="https://replacepart/api/pic/7"
              , CatalogBrandId=4, CatalogTypeId=3},
               new CatalogItem{ Name="Item 8", Description="Desc 8", Price=580m, PictureFileName="pic8", PictureUrl="https://replacepart/api/pic/8"
              , CatalogBrandId=4, CatalogTypeId=2},
               new CatalogItem{ Name="Item 9", Description="Desc 9", Price=245m, PictureFileName="pic9", PictureUrl="https://replacepart/api/pic/9"
              , CatalogBrandId=1, CatalogTypeId=1},
               new CatalogItem{ Name="Item 10", Description="Desc 10", Price=256m, PictureFileName="pic10", PictureUrl="https://replacepart/api/pic/10"
              , CatalogBrandId=1, CatalogTypeId=1},
               new CatalogItem{ Name="Item 11", Description="Desc 11", Price=211m, PictureFileName="pic11", PictureUrl="https://replacepart/api/pic/11"
              , CatalogBrandId=5, CatalogTypeId=3},
               new CatalogItem{ Name="Item 12", Description="Desc 12", Price=234m, PictureFileName="pic12", PictureUrl="https://replacepart/api/pic/12"
              , CatalogBrandId=2, CatalogTypeId=3}

            };
        }
    }
}