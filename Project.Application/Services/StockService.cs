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
        public async Task<List<StockInDto>> GetAllStocksAsync()
        {
            try
            {
                var stocks = await _stockRepository.GetAllStocksAsync();
                return stocks
                       .Select(s => new StockInDto
                       {
                           StockId = s.StockId,
                           ProductQuantity = s.ProductQuantity,
                           ProductId = s.ProductId,
                           ProductName = s.Product?.ProductName,
                           ProductCode = s.Product?.ProductCode,
                           ProductStatus = s.ProductStatus
                       })
                       .ToList();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task AddStocksAsync(List<StockInDto> stockInDto)
        {
            var stocks = stockInDto
                .Select(s => new Stock
                {
                    ProductQuantity = s.ProductQuantity,
                    ProductId = s.ProductId,
                })
                .ToList();
            try
            {
                await _stockRepository.AddStocksAsync(stocks);
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
    }
}
