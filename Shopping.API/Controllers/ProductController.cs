using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(ILogger<ProductController> logger, ProductContext context) : ControllerBase
    {

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            //return ProductContext.ProductsList;
            return await context.Products.Find(p => true).ToListAsync();
        }
    }
}
