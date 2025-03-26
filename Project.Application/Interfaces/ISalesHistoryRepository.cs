using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces
{
    public interface ISalesHistoryRepository
    {
        Task<IEnumerable<SalesHistory>> GetAllSalesHistoryAsync();

        Task AddSalesHistoryAsync(SalesHistory salesHistory);
    }
}
