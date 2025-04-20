using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Interfaces
{
    public interface ISalesDetailRepository
    {
        Task<IEnumerable<SalesDetail>> GetAllSalesByDateAsync(DateOnly startDate, DateOnly endDate);
        Task AddSalesAsync(IEnumerable<SalesDetail> sales);
    }
}
