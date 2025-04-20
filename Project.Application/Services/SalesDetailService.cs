using Project.Application.DTOs.SalesDetialDtos;
using Project.Application.Interfaces;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services
{
    public class SalesDetailService
    {
        private readonly ISalesDetailRepository _salesDetailRepository;
        public SalesDetailService(ISalesDetailRepository salesDetailRepository)
        {
            _salesDetailRepository = salesDetailRepository;
        }
        public async Task<List<GetAllSalesByDateDto>> GetAllSalesByDateAsync(DateOnly startDate, DateOnly endDate)
            {
                try
                {
                    var sales = await _salesDetailRepository.GetAllSalesByDateAsync(startDate, endDate);

                    if(sales == null || !sales.Any())
                    {
                        throw new InvalidOperationException("No sales found in the database");
                    }

                    return sales.Select(x => new GetAllSalesByDateDto
                    {
                        SalesHistoryId = x.SalesHistoryId,
                        ProductCode = x.ProductCode,
                        ProductName = x.ProductName,
                        ProductPrice = x.UnitPrice,
                        ProductQuantity = x.QuantitySold,
                        TotalAmount = x.TotalAmount,
                    }).ToList();
                }
                catch (InvalidOperationException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
        }
        public async Task<List<GetSalesByQtyDto>> GetSalesByQtyAsync(DateOnly startDate, DateOnly endDate)
        {
            try
            {
                var sales = await _salesDetailRepository.GetAllSalesByDateAsync(startDate, endDate);

                if (sales == null || !sales.Any())
                {
                    throw new InvalidOperationException("No sales found in the database");
                }

                return sales
                       .GroupBy(sd => new { sd.ProductCode, sd.ProductName })
                       .Select(sd => new GetSalesByQtyDto
                       {
                           ProductCode = sd.Key.ProductCode,
                           ProductName = sd.Key.ProductName,
                           ProductQuantity = sd.Sum(sd => sd.QuantitySold),
                           TotalAmount = sd.Sum(sd => sd.TotalAmount),
                       })
                       .OrderByDescending(x => x.ProductQuantity)
                       .Take(10)
                       .ToList();

            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<List<GetSalesByQtyDto>> GetSalesByTotalAmountAsync(DateOnly startDate, DateOnly endDate)
        {
            try
            {
                var sales = await _salesDetailRepository.GetAllSalesByDateAsync(startDate, endDate);

                if (sales == null || !sales.Any())
                {
                    throw new InvalidOperationException("No sales found in the database");
                }

                return sales
                       .GroupBy(sd => new { sd.ProductCode, sd.ProductName })
                       .Select(sd => new GetSalesByQtyDto
                       {
                           ProductCode = sd.Key.ProductCode,
                           ProductName = sd.Key.ProductName,
                           ProductQuantity = sd.Sum(sd => sd.QuantitySold),
                           TotalAmount = sd.Sum(sd => sd.TotalAmount),
                       })
                       .OrderByDescending(x => x.TotalAmount)
                       .Take(10)
                       .ToList();

            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task AddSalesAsync(List<AddSalesDetailDto> sales)
        {
            try
            {
                var salesData = sales.Select(s => new SalesDetail
                {
                    SalesHistoryId= s.SalesHistoryId, //transaction id
                    ProductCode = s.ProductCode,
                    ProductName = s.ProductName,
                    QuantitySold = s.QuantitySold,
                    UnitPrice = s.UnitPrice,
                }).ToList();

                await _salesDetailRepository.AddSalesAsync(salesData);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

    }
}
