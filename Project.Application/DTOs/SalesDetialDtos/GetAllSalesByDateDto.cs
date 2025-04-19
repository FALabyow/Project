using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs.SalesDetialDtos
{
    public class GetAllSalesByDateDto
    {
        public string? SalesHistoryId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public int ProductQuantity { get; set; }
    }
}
