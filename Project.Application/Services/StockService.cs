using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project.Application.DTOs;
using Project.Application.DTOs.StockDtos;
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
        public async Task<List<GetAllStocksDto>> GetAllStocksAsync()
        {
            try
            {
                var stocks = await _stockRepository.GetAllStocksAsync();
                return stocks.Select(s => new GetAllStocksDto
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
        public async Task<List<GetAllStockAdjustmentsDto>> GetAllStocksForAdjustmentsAsync()
        {
            try
            {
                var stocks = await _stockRepository.GetAllStocksAsync();
                return stocks.Select(s => new GetAllStockAdjustmentsDto
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
        public async Task AddStocksAsync(AddStocksDto addStocksDto)
        {
            var stock = new Stock
            {
                ProductId = addStocksDto.ProductId,
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
        public async Task UpdateStocksAsync(List<UpdateStocksDto> updateStocksDto)
        {
            try
            {
                var stockIds = updateStocksDto.Select(s => s.StockId).ToList();
                var stocks = await _stockRepository.GetStocksByIdsAsync(stockIds);

                foreach (var stock in stocks)
                {
                    var dto = updateStocksDto.FirstOrDefault(s => s.StockId == stock.StockId);
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
        public async Task UpdateStocksQtyAsync(List<UpdateStocksDto> updateStocksDto)
        {
            try
            {
                var stockIds = updateStocksDto.Select(s => s.StockId).ToList();
                var stocks = await _stockRepository.GetStocksByIdsAsync(stockIds);

                foreach (var stock in stocks)
                {
                    var dto = updateStocksDto.FirstOrDefault(s => s.StockId == stock.StockId);
                    if (dto != null)
                    {
                        stock.ProductQuantity = dto.ProductQuantity;
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
        public async Task UpdateStockAsync(UpdateStocksDto updateStocksDto)
        {
            try
            {
                var stock = await _stockRepository.GetStockByIdAsync(updateStocksDto.StockId);

                stock.ProductQuantity = updateStocksDto.ProductQuantity;

                await _stockRepository.UpdateStockAsync(stock);
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
        public async Task DeleteStockAsync(Guid id)
        {
            try
            {
                await _stockRepository.DeleteStockAsync(id);
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
    }
}
