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
    public class SalesHistoryRepository : ISalesHistoryRepository
    {
        private readonly ProjectDbContext _context;
        public SalesHistoryRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SalesHistory>> GetAllSalesHistoryAsync()
        {
            try
            {
                var res = await _context.SalesHistory.ToListAsync();
                return res;
            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist or access denied!", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while fetching sales history.", ex);
            }
        }
        public async Task AddSalesHistoryAsync(SalesHistory salesHistory)
        {
            try
            {
                await _context.SalesHistory.AddAsync(salesHistory);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                {
                    throw new InvalidOperationException("Error saving sales history");
                }

            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist");
            }
            catch (Exception)
            {
                throw new InvalidOperationException("An error occurred while adding sales history.");
            }

        }

    }
}
