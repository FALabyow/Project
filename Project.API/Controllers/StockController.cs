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
        public async Task<ActionResult<IEnumerable<StockDto>>> GetAllStocksAsync()
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

        [HttpGet("/Stocks/Adjustments/All")]
        public async Task<ActionResult<IEnumerable<StockAdjustmentsDto>>> GetAllStocksForAdjustmentsAsync()
        {
            try
            {
                var stocks = await _stockService.GetAllStocksForAdjustmentsAsync();
                return Ok(stocks);  
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new 
                { 
                    error = "An unexpected error occurred.", 
                    details = ex.Message 
                });
            }

        }

        [HttpPost("/Stock/AddStock")]
        public async Task<IActionResult> AddStocksAsync([FromBody] StockDto stockDto)
        {
            try
            {
                await _stockService.AddStocksAsync(stockDto);
                return NoContent();

            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }

        }

        [HttpPatch("/Stocks/UpdateStocks")]
        public async Task<IActionResult> UpdateStocksAsync([FromBody] List<StockDto> stockDtos)
        {
            if(stockDtos == null || !stockDtos.Any())
            {
                return BadRequest("Stock list cannot be empty");
            }

            try
            {
                await _stockService.UpdateStocksAsync(stockDtos);
                return NoContent();
            }
            catch (ArgumentNullException ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPut("/Stock/StockAdjustments/UpdateStock/{id}")]
        public async Task<IActionResult> UpdateStockAsync(Guid id, StockAdjustmentsDto stockAdjustmentsDto)
        {
            if(id != stockAdjustmentsDto.StockId)
            {
                return BadRequest(new { error = "ID doesn't match" });
            }

            try
            {
                await _stockService.UpdateStockAsync(stockAdjustmentsDto);
                return NoContent();
            }
            catch(KeyNotFoundException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }


    }
}
