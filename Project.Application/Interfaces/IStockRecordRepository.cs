using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces
{
    public interface IStockRecordRepository
    {
        Task<IEnumerable<StockRecord>> GetAllStockRecordsAsync();
        Task<IEnumerable<StockRecord>> GetAllStockRecordsAsyncByDate(DateOnly startDate, DateOnly endDate);
        Task AddStockRecordsAsync(IEnumerable<StockRecord> stockRecords);
    }
}
