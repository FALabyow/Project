using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.Services;

namespace Project.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class SalesDetailController : ControllerBase
    {
        private readonly SalesDetailService _salesDetailService;
        public SalesDetailController(SalesDetailService salesDetailService)
        {
            _salesDetailService = salesDetailService;
        }
        
        [HttpGet("/SalesDetails/All")]
        public async Task<ActionResult<IEnumerable<StockRecordDto>>> GetAllSalesDetailsAsync()
        {
            try
            {
                var salesDetails = await _salesDetailService.GetAllSalesDetailsAsync();
                return Ok(salesDetails);
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

        [HttpPost("/SalesDetails/AddMultipleSalesDetail")]
        public async Task<IActionResult> AddSalesDetailsAsync([FromBody] List<SalesDetailInfoDto> salesDetailInfoDtos)
        {
            if (salesDetailInfoDtos == null || !salesDetailInfoDtos.Any())
            {
                return BadRequest(new { error = "No details provided." });
            }

            try
            {
                await _salesDetailService.AddSalesDetailsAsync(salesDetailInfoDtos);
                return Ok(salesDetailInfoDtos);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
