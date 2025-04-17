using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model.DTOs
{
    public class SalesDetail
    {
        public string? ProductCode { get; set; } 
        public string? ProductName { get; set; }
        public string? SalesHistoryId { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
