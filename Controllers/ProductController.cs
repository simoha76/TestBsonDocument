using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using TestBsonDocument.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestBsonDocument.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public Product Get()
        {
            Product prod = new Product();
            prod.ProductName = "Test";
            prod.ProductCount = 20;
            var doc = new BsonDocument
            {
                { "metadata1", "val1" }
            };
            prod.ProductMetadata = doc;
            return prod;
        }

    }
}
