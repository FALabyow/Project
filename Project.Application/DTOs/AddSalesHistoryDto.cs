using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class AddSalesHistoryDto
    {
        public Guid SalesHistoryId { get; set; } //this if for invoice number
        public decimal TotalAmount { get; set; } // the total amount recorded for each transaction
    }
}
