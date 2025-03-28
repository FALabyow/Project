using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
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

        //[HttpGet("/StockRecords/All")]
        //public async Task<ActionResult<IEnumerable<StockRecordDto>>> GetAllStockRecordsAsync()
        //{
        //    try
        //    {
        //        var records = await _stockRecordService.GetAllStockRecordsAsync();
        //        return Ok(records);
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        return BadRequest(new { error = ex.Message });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, new { error = "An unexpected error occurred.", details = ex.Message });
        //    }
        //}

        //[HttpPost("/StockRecord/AddRecord")]
        //public async Task<IActionResult> AddStockRecordAsync([FromBody] StockRecordInfoDto stockRecordInfoDto)
        //{
        //    try
        //    {
        //        await _stockRecordService.AddStockRecordAsync(stockRecordInfoDto);
        //        return Ok(stockRecordInfoDto);

        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        return BadRequest(new { error = ex.Message });
        //    }

        //}
        
        //[HttpPost("/StockRecord/AddMultipleRecords")]
        //public async Task<IActionResult> AddStockRecordsAsync([FromBody] List<StockRecordInfoDto> stockRecordInfoDtos)
        //{
        //    if (stockRecordInfoDtos == null || !stockRecordInfoDtos.Any())
        //    {
        //        return BadRequest(new { error = "No stock records provided." });
        //    }

        //    try
        //    {
        //        await _stockRecordService.AddStockRecordsAsync(stockRecordInfoDtos);
        //        return Ok(new { message = "Stock records added successfully." });
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        return BadRequest(new { error = ex.Message });
        //    }
        //}
    }
}
