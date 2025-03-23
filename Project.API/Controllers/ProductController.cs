using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.Services;

namespace Project.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("/Products/All")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllCategoryAsync()
        {
            try
            {
                var products = await _productService.GetAllProductAsync();
                return Ok(products);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An unexpected error occurred.", details = ex.Message });
            }

        }
        [HttpPost("/Product/AddProduct")]
        public async Task<IActionResult> AddCategoryAsync([FromBody] ProductInfoDto productInfoDto)
        {
            try
            {
                await _productService.AddProductAsync(productInfoDto);
                return Ok(productInfoDto);
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new {error = ex.Message});    
            }
            
        }
    }
}
