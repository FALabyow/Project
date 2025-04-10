using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetAllStocksAsync();
        Task<Stock> GetStockByIdAsync(Guid id);
        Task AddStockAsync(Stock stock);
        Task UpdateStocksAsync(IEnumerable<Stock> stocks);
        Task UpdateStockAsync(Stock stock);
        Task DeleteStockAsync(Guid id);
        Task<IEnumerable<Stock>> GetStocksByIdsAsync(IEnumerable<Guid> ids);
    }
}
