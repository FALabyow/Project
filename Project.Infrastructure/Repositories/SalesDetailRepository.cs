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
    public class SalesDetailRepository : ISalesDetailRepository
    {
        private readonly ProjectDbContext _context;
        public SalesDetailRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SalesDetail>> GetAllSalesDetailAsync()
        {
            try
            {
                return await _context.SalesDetails
                    .Include(sd => sd.SalesHistory)
                    .ToListAsync();

            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 4060)
            {
                throw new InvalidOperationException("Database does not exist or access denied!", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while fetching sales history." + ex.Message);
            }
        }
        public async Task AddSalesDetailAsync(IEnumerable<SalesDetail> salesDetails)
        {
            try
            {
                await _context.SalesDetails.AddRangeAsync(salesDetails);
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
                throw new InvalidOperationException("An error occurred while adding sales detail.");
            }
        }
    
    }
}
