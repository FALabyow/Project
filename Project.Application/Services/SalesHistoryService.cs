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
    public class SalesHistoryService
    {
        private readonly ISalesHistoryRepository _salesHistoryRepository;
        public SalesHistoryService(ISalesHistoryRepository salesHistoryRepository)
        {
            _salesHistoryRepository = salesHistoryRepository;
        }
        public async Task<List<SalesHistoryDto>> GetAllSalesHistoryAsync()
        {
            try
            {
                var salesHistory = await _salesHistoryRepository.GetAllSalesHistoryAsync();
                if (!salesHistory.Any())
                    throw new InvalidOperationException("No sales history found in the database!");

                return salesHistory.Select(sh => new SalesHistoryDto
                {
                    InvoiceNumber = sh.InvoiceNumber,
                    TotalAmount = sh.TotalAmount,
                    SaleDate = sh.SaleDate,
                    SalesHistoryId = sh.SalesHistoryId
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
        public async Task AddSalesHistoryAsync(SalesHistoryInfoDto salesHistoryInfoDto)
        {
            var salesHistory = new SalesHistory
            {
                InvoiceNumber= salesHistoryInfoDto.InvoiceNumber,
                TotalAmount= salesHistoryInfoDto.TotalAmount,
                SalesHistoryId = salesHistoryInfoDto.SalesHistoryId
            };

            try
            {
                await _salesHistoryRepository.AddSalesHistoryAsync(salesHistory);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }


    }
}
