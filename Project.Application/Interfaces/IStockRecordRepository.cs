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
        //Task<IEnumerable<StockRecord>> GetAllStockRecordsAsync();
        Task AddStockRecordAsync(StockRecord stockRecord);
        Task AddStockRecordsAsync(IEnumerable<StockRecord> stockRecords);
    }
}
