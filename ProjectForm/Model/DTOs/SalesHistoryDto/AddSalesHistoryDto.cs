using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model.DTOs.SalesHistoryDto
{
    public class AddSalesHistoryDto
    {
        public string? SalesHistoryId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
