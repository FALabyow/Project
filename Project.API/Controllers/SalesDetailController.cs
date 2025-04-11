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
        
        [HttpGet("/Sales/All/FilteredBy")]
        public async Task<ActionResult<IEnumerable<GetAllSalesByDateDto>>> GetAllSalesByDateAsync(DateTime startDate, DateTime  endDate)
        {
            try
            {
                var sales = await _salesDetailService.GetAllSalesByDateAsync(startDate, endDate);
                return Ok(sales);
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("/Sales/AddSales")]
        public async Task<IActionResult> AddSalesAsync([FromBody] List<AddSalesDto> sales)
        {
            try
            {
                await _salesDetailService.AddSalesAsync(sales);
                return Ok();
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(new {error =  ex.Message});
            }
            catch(ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }


    }
}
