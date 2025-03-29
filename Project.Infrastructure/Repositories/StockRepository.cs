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
        public async Task AddStocksAsync(IEnumerable<Stock> stocks)
        {
            try
            {
                await _context.Stocks.AddRangeAsync(stocks);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                {
                    throw new InvalidOperationException(ex.Message);
                }

            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist");
            }
            catch (Exception)
            {
                throw new InvalidOperationException("An error occurred while adding stocks.");
            }
        }


    }
}
