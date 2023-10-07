using Microsoft.AspNetCore.Mvc;

namespace DotNet.Ocelot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Descriptions = new[] {
            "Premium Leather Wallet",
            "Smartphone with AI Camera",
            "Luxury Swiss Watch",
            "Wireless Noise-Canceling Headphones",
            "Designer Sunglasses",
            "High-Performance Gaming Laptop",
            "Organic Skincare Set",
            "Stylish Fitness Tracker",
            "Elegant Dinnerware Set",
            "Handcrafted Artisanal Chocolate"
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Product
            {
                Description = Descriptions[Random.Shared.Next(Descriptions.Length)],
                ProductId = Random.Shared.Next(),
            })
            .ToArray();
        }
    }
}