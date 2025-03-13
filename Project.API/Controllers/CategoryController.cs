using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.Services;

namespace Project.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("/Categories/All")]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAllCategoryAsync()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            return Ok(categories);
        }
        [HttpPost("/Category/AddCategory")]
        public async Task<IActionResult> AddCategoryAsync([FromBody] CategoryInfoDto categoryInfoDto)
        {
            await _categoryService.AddCategoryAsync(categoryInfoDto);
            return Ok(categoryInfoDto);
        }

    }
}
