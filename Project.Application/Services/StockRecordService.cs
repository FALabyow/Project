using Project.Application.DTOs;
using Project.Application.Interfaces;
using Project.Domain.Entities;
using ProjectForm.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Services
{
    public class StockRecordService
    {
        private readonly IStockRecordRepository _stockRecordRepository;
        public StockRecordService(IStockRecordRepository stockRecordRepository)
        {
            _stockRecordRepository = stockRecordRepository;
        }
        public async Task<List<StockRecordDto>> GetAllStockRecordsAsync()
        {
            try
            {
                var stockRecords = await _stockRecordRepository.GetAllStockRecordsAsync();
                if (!stockRecords.Any())
                    throw new InvalidOperationException("No stock records found in the database!");

                return stockRecords.Select(b => new StockRecordDto
                {
                    StockRecordId = b.StockRecordId,
                    ReferenceNum = b.ReferenceNum,
                    StockInQty = b.StockInQty,
                    StockInDate = b.StockInDate,
                    ProductName = b.ProductName,
                    ProductCode = b.ProductCode,
                    ProductCategory = b.ProductCategory,
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
        public async Task<List<GetStockInHistoryDto>> GetStockInHistoryAsync(DateOnly startDate, DateOnly endDate)
        {
            try
            {
                var stockRecords = await _stockRecordRepository.GetAllStockRecordsAsyncByDate(startDate, endDate);
                if (!stockRecords.Any())
                    throw new InvalidOperationException("No stock records found in the database!");

                return stockRecords.Select(b => new GetStockInHistoryDto
                {                    
                    ReferenceNum = b.ReferenceNum,
                    ProductQuantity = b.StockInQty,
                    StockInDate = b.StockInDate,
                    ProductName = b.ProductName,
                    ProductCode = b.ProductCode,
                    
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
        public async Task AddStockRecordsAsync(IEnumerable<StockRecordDto> stockRecordDtos)
        {
            var stockRecords = stockRecordDtos.Select(dto => new StockRecord
            {
                ReferenceNum = dto.ReferenceNum,
                StockInQty = dto.StockInQty,
                StockInDate = dto.StockInDate,
                ProductName = dto.ProductName,
                ProductCode = dto.ProductCode,
                ProductCategory = dto.ProductCategory,               
            }).ToList();

            try
            {
                await _stockRecordRepository.AddStockRecordsAsync(stockRecords);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
    }
}
