using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class StockRecord
    {
        public Guid StockRecordId { get; set; } = Guid.NewGuid();
        public string? ReferenceNum { get; set; }
        public int StockInQty { get; set; }
        public DateOnly StockInDate { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

        

    }
}
