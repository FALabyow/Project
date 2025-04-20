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
        public async Task<IEnumerable<SalesDetail>> GetAllSalesByDateAsync(DateOnly startDate, DateOnly endDate)
        {
            try
            {
                var stocks = await _context.SalesDetails
                .Where(x => x.SalesHistory!= null && 
                            x.SalesHistory.SaleDate >= startDate &&  
                            x.SalesHistory.SaleDate <= endDate)
                .ToListAsync();

                return stocks;
            }
            catch (InvalidOperationException ex) when (ex.InnerException is SqlException sqlEx && sqlEx.Number == 40060)
            {
                throw new InvalidOperationException("Access Denied! " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occured while fetching sales. " + ex.Message);
            }
            
        }
        public async Task AddSalesAsync(IEnumerable<SalesDetail> sales)
        {
            try
            {
                if(!sales.Any())
                {
                    throw new ArgumentException("Data is empty");
                }
                await _context.SalesDetails.AddRangeAsync(sales);
                await _context.SaveChangesAsync();
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch(DbUpdateException ex)
            {
                throw new InvalidOperationException("A problem occured while saving data: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
