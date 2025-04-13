using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.DTOs;
using Project.Application.Services;

namespace Project.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class SalesHistoryController : ControllerBase
    {
        private readonly SalesHistoryService _salesHistoryService;
        public SalesHistoryController(SalesHistoryService salesHistoryService)
        {
            _salesHistoryService = salesHistoryService;
        }

        [HttpGet("/SalesHistory/All")]
        //public async Task<ActionResult<IEnumerable<GetSaleDto>>> GetAllSalesHistoryAsync()
        //{
        //    try
        //    {
        //        var salesHistory = await _salesHistoryService.GetAllSalesHistoryAsync();
        //        return Ok(salesHistory);
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

        [HttpPost("/SalesHistory/AddSalesHistory")]
        public async Task<IActionResult> AddSalesHistoryAsync([FromBody] AddSalesHistoryDto salesHistory)
        {
            try
            {
                await _salesHistoryService.AddSalesHistoryAsync(salesHistory);
                return Ok(salesHistory.SalesHistoryId);
                

            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }

        }
    }
}
