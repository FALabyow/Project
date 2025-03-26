using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class SalesDetailDto
    {
        public string InvoiceNumber { get; set; } = string.Empty;
        public Guid SalesDetailId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int QuantitySold { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }

    }
}
