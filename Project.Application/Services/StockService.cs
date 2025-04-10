using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public class StockService
    {
        private readonly IStockRepository _stockRepository;
        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }
        public async Task<List<StockDto>> GetAllStocksAsync()
        {
            try
            {
                var stocks = await _stockRepository.GetAllStocksAsync();
                return stocks.Select(s => new StockDto
                {
                    StockId = s.StockId,
                    ProductQuantity = s.ProductQuantity,
                    ProductId = s.ProductId,
                    ProductName = s.Product?.ProductName,
                    ProductCode = s.Product?.ProductCode,
                    ProductCategory = s.Product?.Category?.CategoryName,

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
        public async Task<List<StockAdjustmentsDto>> GetAllStocksForAdjustmentsAsync()
        {
            try
            {
                var stocks = await _stockRepository.GetAllStocksAsync();
                return stocks.Select(s => new StockAdjustmentsDto
                {
                    StockId = s.StockId,
                    ProductQuantity = s.ProductQuantity,
                    ProductBarcode = s.Product?.BarcodeData,
                    ProductName = s.Product?.ProductName,
                    ProductCode = s.Product?.ProductCode,
                    ProductCategory= s.Product?.Category?.CategoryName,
                    ProductPrice = s.Product?.ProductPrice ?? 0
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
        public async Task AddStocksAsync(StockDto stockDto)
        {
            var stock = new Stock
            {
                ProductQuantity = stockDto.ProductQuantity,
                ProductId = stockDto.ProductId,
            };
                
            try
            {
                await _stockRepository.AddStockAsync(stock);
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
        public async Task UpdateStocksAsync(List<StockDto> stockDtos)
        {
            try
            {
                var stockIds = stockDtos.Select(s => s.StockId).ToList();
                var stocks = await _stockRepository.GetStocksByIdsAsync(stockIds);

                foreach (var stock in stocks)
                {
                    var dto = stockDtos.FirstOrDefault(s => s.StockId == stock.StockId);
                    if (dto != null)
                    {
                        stock.ProductQuantity += dto.ProductQuantity;
                    }
                }

                await _stockRepository.UpdateStocksAsync(stocks);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            

        }
        
    }
}
