using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.Services;
using ProjectForm.Model.DTOs;

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
        public async Task<ActionResult<IEnumerable<GetSalesDetailDto>>> GetAllSalesByDateAsync(DateOnly startDate, DateOnly  endDate)
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

        [HttpGet("/Sales/TopSelling/FilteredBY")]
        public async Task<ActionResult<IEnumerable<POSrecordDto1>>> GetTopSellingProductAsync(DateOnly startDate, DateOnly endDate, string action)
        {
            try
            {
                if(action == "SortByQty")
                {
                    var sales = await _salesDetailService.GetSalesByQtyAsync(startDate, endDate);
                    return Ok(sales);
                }
                else if(action == "SortByTotalAmount")
                {
                    var sales = await _salesDetailService.GetSalesByTotalAmountAsync(startDate, endDate);
                    return Ok(sales);
                }
                
                return NoContent();

                
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("/Sales/AddSales")]
        public async Task<IActionResult> AddSalesAsync([FromBody] List<AddSalesDetailDto> sales)
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
