using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class SalesHistoryInfoDto
    {
        public string InvoiceNumber { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
    }
}
