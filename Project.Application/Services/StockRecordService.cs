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
                    ProductName = b.Product?.ProductName,
                    ProductCode = b.Product?.ProductCode,   
                    ProductId = b.ProductId,
                    ReferenceNum = b.ReferenceNum,
                    StockInDate = b.StockInDate,
                    StockInQty = b.StockInQty


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
        public async Task AddStockRecordAsync(StockRecordInfoDto stockRecordInfoDto)
        {
            var stockRecord = new StockRecord
            {
                ProductId = stockRecordInfoDto.ProductId,
                StockInQty = stockRecordInfoDto.StockInQty,
                StockInDate = stockRecordInfoDto.StockInDate,
                ReferenceNum= stockRecordInfoDto.ReferenceNum,
            };

            try
            {
                await _stockRecordRepository.AddStockRecordAsync(stockRecord);
            }
            catch (InvalidOperationException)
            {
                throw;
            }



        }
        public async Task AddStockRecordsAsync(IEnumerable<StockRecordInfoDto> stockRecordInfoDtos)
        {
            var stockRecords = stockRecordInfoDtos.Select(dto => new StockRecord
            {
                ProductId = dto.ProductId,
                StockInQty = dto.StockInQty,
                StockInDate = dto.StockInDate,
                ReferenceNum = dto.ReferenceNum,
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
