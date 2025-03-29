using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.Services;

namespace Project.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly StockService _stockService;
        public StockController(StockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("/Stocks/All")]
        public async Task<ActionResult<IEnumerable<StockInDto>>> GetAllStocksAsync()
        {
            try
            {
                var stocks = await _stockService.GetAllStocksAsync();
                return Ok(stocks);
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

        [HttpPost("/Stocks/AddStocks")]
        public async Task<IActionResult> AddStocksAsync([FromBody] List<StockInDto> stockInDto)
        {
            try
            {
                await _stockService.AddStocksAsync(stockInDto);
                return NoContent();

            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }

        }
    }
}
