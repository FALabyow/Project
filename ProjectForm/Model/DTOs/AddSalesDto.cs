using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class AddSalesDto
    {
        public Guid SalesDetailId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
