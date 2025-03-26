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
        public async Task<List<SalesDetailDto>> GetAllSalesDetailsAsync()
        {
            try
            {
                var salesDetails = await _salesDetailRepository.GetAllSalesDetailAsync();
                if (!salesDetails.Any())
                    throw new InvalidOperationException("No sales details found in the database!");

                return salesDetails.Select(sd => new SalesDetailDto
                {
                    InvoiceNumber = sd.SalesHistory.InvoiceNumber,
                    ProductCode = sd.ProductCode,
                    ProductName = sd.ProductName,
                    QuantitySold = sd.QuantitySold,
                    SalesDetailId = sd.SalesDetailId,
                    UnitPrice = sd.UnitPrice,
                    TotalAmount = sd.TotalAmount,
                    SaleDate = sd.SalesHistory.SaleDate,

                }).ToList();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Unexpected error in service layer", ex);
            }
        }
        public async Task AddSalesDetailsAsync(IEnumerable<SalesDetailInfoDto> salesDetailInfoDtos)
        {
            var salesDetails = salesDetailInfoDtos.Select(sd => new SalesDetail
            {
                SalesHistoryId = sd.SalesHistoryId,
                ProductCode = sd.ProductCode,
                ProductName = sd.ProductName,
                QuantitySold = sd.QuantitySold,
                ProductId = sd.ProductId,
                UnitPrice = sd.UnitPrice,
            }).ToList();

            try
            {
                await _salesDetailRepository.AddSalesDetailAsync(salesDetails);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }

    }
}
