using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PicController: ControllerBase
    {
        private readonly IHostingEnvironment _env;
        public PicController(IHostingEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetImage(int id)
        {
            var rooPath = _env.ContentRootPath;
            var filePath = Path.Combine(rooPath,"Pics",$"produts-{id}.png");
            var buffer = System.Text.Encoding.UTF8.GetBytes(new char[1]);
            if(System.IO.File.Exists(filePath))
             { 
                buffer = System.IO.File.ReadAllBytes(filePath);    
                         
             }
            return File(buffer, "image/png"); 
            //return NoContent();
        }

    }
}