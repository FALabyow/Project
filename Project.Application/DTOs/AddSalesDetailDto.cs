using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class AddSalesDetailDto
    {
        public string? SalesHistoryId { get; set; } //this is for invoice number
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public int QuantitySold { get; set; } //total quantity sold for each item
        public decimal UnitPrice { get; set; } //price for each item
    }
}
