using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class GetSalesDetailDto
    {
        public Guid SalesHistoryId { get; set; } //this is for invoice number
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public int ProductQuantity { get; set; } //total quantity sold for each item
        public decimal ProductPrice { get; set; } //price for each item
        public decimal TotalAmount { get; set; } //total amount for each item sold
    }
}
