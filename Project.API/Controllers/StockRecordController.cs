using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.DTOs.StockrRecordDtos;
using Project.Application.Services;

namespace Project.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class StockRecordController : ControllerBase
    {
        private readonly StockRecordService _stockRecordService;
        public StockRecordController(StockRecordService stockRecordService)
        {
           _stockRecordService = stockRecordService;
        }

        [HttpGet("/StockRecords/All")]
        public async Task<ActionResult<IEnumerable<GetAllStocksRecordDto>>> GetAllStockRecordsAsync()
        {
            try
            {
                var records = await _stockRecordService.GetAllStockRecordsAsync();
                return Ok(records);
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

        [HttpGet("/StockRecords/History/FilteredBy")]
        public async Task<ActionResult<IEnumerable<GetStockInHistoryDto>>> GetStockInHistoryAsync(DateOnly startDate, DateOnly endDate)
        {
            try
            {
                var records = await _stockRecordService.GetStockInHistoryAsync(startDate, endDate);
                return Ok(records);
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

        [HttpPost("/StockRecord/AddMultipleRecords")]
        public async Task<IActionResult> AddStockRecordsAsync([FromBody] List<AddStockRecordsDto> addStockRecordDtos)
        {
            if (addStockRecordDtos == null || !addStockRecordDtos.Any())
            {
                return BadRequest(new { error = "No stock records provided." });
            }

            try
            {
                await _stockRecordService.AddStockRecordsAsync(addStockRecordDtos);
                return Ok(new { message = "Stock records added successfully." });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
