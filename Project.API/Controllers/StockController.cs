using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.DTOs.StockDtos;
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
        public async Task<ActionResult<IEnumerable<GetAllStocksDto>>> GetAllStocksAsync()
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
        public async Task<ActionResult<IEnumerable<GetAllStockAdjustmentsDto>>> GetAllStocksForAdjustmentsAsync()
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
        public async Task<IActionResult> AddStocksAsync([FromBody] AddStocksDto addStocksDto)
        {
            try
            {
                await _stockService.AddStocksAsync(addStocksDto);
                return NoContent();

            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }

        }

        [HttpPatch("/Stocks/UpdateStocks")]
        public async Task<IActionResult> UpdateStocksAsync([FromBody] List<UpdateStocksDto> updateStocksDto)
        {
            if(updateStocksDto == null || !updateStocksDto.Any())
            {
                return BadRequest("Stock list cannot be empty");
            }

            try
            {
                await _stockService.UpdateStocksAsync(updateStocksDto);
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

        [HttpPatch("/Stocks/UpdateStocks/Quantity")]
        public async Task<IActionResult> UpdateStocksQtyAsync([FromBody] List<UpdateStocksDto> updateStocksDto)
        {
            if (updateStocksDto == null || !updateStocksDto.Any())
            {
                return BadRequest("Stock list cannot be empty");
            }

            try
            {
                await _stockService.UpdateStocksQtyAsync(updateStocksDto);
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
        public async Task<IActionResult> UpdateStockAsync(Guid id, UpdateStocksDto updateStocksDto)
        {
            if(id != updateStocksDto.StockId)
            {
                return BadRequest(new { error = "ID doesn't match" });
            }

            try
            {
                await _stockService.UpdateStockAsync(updateStocksDto);
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

        [HttpDelete("/Stock/StockAdjustments/DeleteStock/{id}")]
        public async Task<IActionResult> DeleteStockAsync(Guid id)
        {
            try
            {
                await _stockService.DeleteStockAsync(id);
                return NoContent();
            }
            catch(KeyNotFoundException ex)
            {
                return BadRequest(new {error = ex.Message});    
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch(Exception ex)
            {
                return StatusCode(500, new
                {
                    error = ex.Message,
                });
            }
        }

    }
}
