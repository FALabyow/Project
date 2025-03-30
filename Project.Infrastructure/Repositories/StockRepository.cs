using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project.Application.DTOs;
using Project.Application.Interfaces;
using Project.Domain.Entities;
using Project.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly ProjectDbContext _context;
        public StockRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Stock>> GetAllStocksAsync()
        {
            try
            {
                var stocks = await _context.Stocks
                    .Include(p => p.Product)
                    .ToListAsync();
                return stocks;
            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist or access denied!", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while fetching stocks.", ex);
            }
        }
        public async Task<IEnumerable<Stock>> GetStocksByIdAsync(IEnumerable<Guid> ids)
        {
            var stocks = await _context.Stocks
                .Where(s => ids.Contains(s.StockId))
                .ToListAsync();
            return stocks;
        }
        public async Task AddStockAsync(Stock stock)
        {
            try
            {
                await _context.Stocks.AddAsync(stock);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("Duplicate product id detected!" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public async Task UpdateStocksAsync(IEnumerable<Stock> stocks)
        {
            try
            {
                if(stocks == null || !stocks.Any())
                {
                    throw new ArgumentNullException(nameof(stocks), "Stocks cannot be empty");
                }

                _context.Stocks.UpdateRange(stocks);
                await _context.SaveChangesAsync();  
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("The stocks cannot be updated: " + ex.Message);
            }
        }
        public async Task<List<Stock>> GetStocksByIdsAsync(IEnumerable<Guid> ids)
        {
            var stocks = await _context.Stocks
                .Where(s => ids.Contains(s.StockId))
                .ToListAsync();

            return stocks;
        }



    }
}
