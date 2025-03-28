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
        public int StockInQty { get; set; } //how many quantity is recorded
        public DateOnly StockInDate { get; set; } // when it was recorded   
        public string? ProductName { get; set; } //the recorded product name
        public string? ProductCode { get; set; } // the recorded product code
        public string? ProductCategory {  get; set; } //the recorded product category

    }
}
