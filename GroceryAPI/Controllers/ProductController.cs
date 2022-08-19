using GroceryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryAPI.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("List")]
        public IActionResult List()      
        {
            try
            {
                var product = _productRepository.AllProduct;
                return Ok(product);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpGet]
        [Route("ProductOfTheWeek")]
        public IActionResult ProductOfTheWeek()
        {
            try
            {
                var ProductOfWeek = _productRepository.ProductOfTheWeek;
                return Ok(ProductOfWeek);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }

        [HttpGet("{id}", Name = "Details")]
        public IActionResult Details(int id)
        {
            try
            {
                var GetProductById = _productRepository.GetProductById(id);
                if (GetProductById == null)
                {
                    return NotFound("Product Not Found");
                }
                return Ok(GetProductById);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }       
    }
}
