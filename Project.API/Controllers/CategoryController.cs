using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            try
            {
                var categories = await _categoryService.GetAllCategoryAsync();
                return Ok(categories);
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

        [HttpPost("/Category/AddCategory")]
        public async Task<IActionResult> AddCategoryAsync([FromBody] CategoryDto categoryDto)
        {
            try
            {
                await _categoryService.AddCategoryAsync(categoryDto);
                return NoContent();

            }
            catch(ArgumentNullException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new {error = ex.Message});
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An unexpected error occurred.", details = ex.Message });
            }

        }
        
        [HttpPut("/Category/Update/{id}")]
        public async Task<IActionResult> UpdateCategoryAsync(Guid id, [FromBody] CategoryDto categoryDto)
        {
            if(id != categoryDto.CategoryId) return BadRequest(new {error = "Id doesn't match"});
            try
            {
                await _categoryService.UpdateCategoryAsync(categoryDto);
                return NoContent();
            }
            catch(KeyNotFoundException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch(ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message});
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An unexpected error occurred.", details = ex.Message });
            }
        }

        [HttpDelete("/Category/Delete/{id}")]
        public async Task<IActionResult> DeleteCategoryAsync(Guid id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
                return NoContent();

            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    StatusCode = 500,
                    Message = "An unexpected error occurred.",
                    Details = ex.Message
                });
            }
        }

    }
}
