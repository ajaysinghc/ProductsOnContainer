using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Data;

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CatalogController: ControllerBase
    {
        readonly CatalogContext _context;
        public CatalogController(CatalogContext context)
        {
            _context = context;
        }
        
    }
}