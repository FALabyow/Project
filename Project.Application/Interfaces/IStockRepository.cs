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
        Task<IEnumerable<Stock>> GetStocksByIdAsync(IEnumerable<Guid> ids);

        Task AddStockAsync(Stock stock);
        Task UpdateStocksAsync(IEnumerable<Stock> stocks);
        Task<List<Stock>> GetStocksByIdsAsync(IEnumerable<Guid> ids);
    }
}
