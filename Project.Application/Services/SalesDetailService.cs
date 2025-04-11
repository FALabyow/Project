using Project.Application.DTOs;
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
        public async Task<List<GetAllSalesByDateDto>> GetAllSalesByDateAsync(DateTime startDate, DateTime endDate)
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
                    SalesDetailId = x.SalesDetailId,
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

        public async Task AddSalesAsync(List<AddSalesDto> sales)
        {
            try
            {
                var salesData = sales.Select(s => new SalesDetail
                {
                    CreatedDate = DateTime.Now,
                    ProductCode = s.ProductCode,
                    ProductName = s.ProductName,
                    QuantitySold = s.QuantitySold,
                    UnitPrice = s.UnitPrice,
                    SalesDetailId = s.SalesDetailId,
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
