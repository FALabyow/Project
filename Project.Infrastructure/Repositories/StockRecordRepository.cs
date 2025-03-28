using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public class StockRecordRepository : IStockRecordRepository
    {
        private readonly ProjectDbContext _context;
        public StockRecordRepository(ProjectDbContext context)
        {
            _context = context;
        }

        //public async Task<IEnumerable<StockRecord>> GetAllStockRecordsAsync()
        //{
        //    try
        //    {
        //        return await _context.StockRecords
        //                .Include(s => s.Product) 
        //                .ToListAsync();
                
        //    }
        //    catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
        //    {
        //        throw new InvalidOperationException("Database does not exist or access denied!", ex);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new InvalidOperationException("An error occurred while fetching stock records." + ex.Message);
        //    }
        //}
        public async Task AddStockRecordAsync(StockRecord stockRecord)
        {
            try
            {
                await _context.StockRecords.AddAsync(stockRecord);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                {
                    throw new InvalidOperationException("Error saving adding record: " + ex.Message);
                }

            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist");
            }
            catch (Exception)
            {
                throw new InvalidOperationException("An error occurred while adding stock record.");
            }

        }
        public async Task AddStockRecordsAsync(IEnumerable<StockRecord> stockRecords)
        {
            try
            {
                await _context.StockRecords.AddRangeAsync(stockRecords); 
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                {
                    throw new InvalidOperationException("Duplicate record error: " + ex.Message);
                }
            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist");
            }
            catch (Exception)
            {
                throw new InvalidOperationException("An error occurred while adding stock records.");
            }
        }

    }
}
